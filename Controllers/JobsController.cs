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
        public async Task<IActionResult> Create([Bind("JobId,JobName,JobDescription,PostcodeFrom,PostcodeTo,TotalMiles")] Job job, JobDetailViewModel jobDetailViewModel)
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
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,JobName,JobDescription,PostcodeFrom,PostcodeTo,TotalMiles")] Job job)
        {
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
        [ValidateAntiForgeryToken]
        public IActionResult CalculateMilage(int value1, int value2)
        {
            TempData["ButtonValue"] = "123";
            return RedirectToAction("Create");
        }
    }
}