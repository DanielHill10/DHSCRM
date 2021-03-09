using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DHSCRM.Data;
using DHSCRM.Models;
using DHSCRM.ViewModels;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DHSCRM.Controllers
{
    public class JobsController : Controller
    {
        private readonly RecordDetailContext _context;

        public JobsController(RecordDetailContext context)
        {
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["JobNumSort"] = string.IsNullOrEmpty(sortOrder) ? "jobNumDesc" : "";
            var jobs = _context.Jobs.Include(j => j.Customer).AsNoTracking();
            switch (sortOrder)
            {
                case "jobNumDesc":
                    jobs = jobs.OrderByDescending(j => j.JobId);
                    break;
                default:
                    jobs = jobs.OrderBy(j => j.JobId);
                    break;
            }
            return View(await jobs.ToListAsync());
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var jobDetailViewModel = new JobDetailViewModel();
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerId == job.CustomerId);
            if (customer != null)
            {
                jobDetailViewModel.Customer = customer;
            }

            jobDetailViewModel.Job = job;

            return View(jobDetailViewModel);
        }

        // GET: Jobs/Create
        public IActionResult Create(JobDetailViewModel model)
        {
            var jobDetailViewModel = new JobDetailViewModel();
            jobDetailViewModel.Customers = _context.Customers.Select(c => new SelectListItem { Value = c.CustomerId.ToString(), Text = c.CustomerName }).ToList();

            return View(jobDetailViewModel);
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobId,JobName,JobDescription,PostcodeFrom,PostcodeTo,TotalMiles, JobDate")] Job job, JobDetailViewModel jobDetailViewModel)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == jobDetailViewModel.Job.CustomerId);
            job.Customer = customer;
            if (ModelState.IsValid)
            {
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var jobDetailViewModel = new JobDetailViewModel();
            jobDetailViewModel.Customers = _context.Customers.Select(c => new SelectListItem { Value = c.CustomerId.ToString(), Text = c.CustomerName }).ToList();

            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            jobDetailViewModel.Job = job;
            return View(jobDetailViewModel);
        }

        // POST: Jobs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,JobName,JobDescription,PostcodeFrom,PostcodeTo,TotalMiles,JobDate")] Job job, JobDetailViewModel jobDetailViewModel)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == jobDetailViewModel.Job.CustomerId);
            job.Customer = customer;
            if (id != job.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.JobId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(int id)
        {
            return _context.Jobs.Any(e => e.JobId == id);
        }

        [HttpPost]
        public async Task<IActionResult> CalculateMilage(string postCodeOne, string postCodeTwo)
        {
            //Get API key from file to avoid storing in code
            string apiKey;
            using (var sr = new StreamReader("C:/Users/Daniel.Hill/OneDrive - Access UK Ltd/Desktop/Personal/googleAPIKey.txt"))
            {
                apiKey = sr.ReadToEnd();
            }
            //Generate CURL URL
            string url;
            url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={postCodeOne}&destinations={postCodeTwo}&mode=driving&key={apiKey}";

            var distanceValue = "";
            decimal distanceValueDecimal;
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                var o = JObject.Parse(responseBody);
                distanceValue = (string)o["rows"][0]["elements"][0]["distance"]["text"];
                distanceValueDecimal = Decimal.Parse(distanceValue.Substring(0, Math.Max(distanceValue.IndexOf(' '), 0)));
            }

            return Json(new
            {
                msg = distanceValueDecimal
            });
        }
    }
}