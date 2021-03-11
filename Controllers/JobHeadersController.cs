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
    public class JobHeadersController : Controller
    {
        private readonly RecordDetailContext _context;

        public JobHeadersController(RecordDetailContext context)
        {
            _context = context;
        }

        // GET: JobHeaders
        public async Task<IActionResult> Index()
        {
            var jobHeader = _context.JobHeader.Include(j => j.Customer).AsNoTracking();
            return View(await jobHeader.ToListAsync());
        }

        // GET: JobHeaders/Create
        public IActionResult Create()
        {
            var jobHeaderDetailViewModel = new JobHeaderDetailViewModel();
            jobHeaderDetailViewModel.Customers = _context.Customers.Select(c => new SelectListItem { Value = c.CustomerId.ToString(), Text = c.CustomerName }).ToList();

            return View(jobHeaderDetailViewModel);
        }

        // POST: JobHeaders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobHeaderId,Name")] JobHeader jobHeader, JobHeaderDetailViewModel jobHeaderDetailViewModel)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == jobHeaderDetailViewModel.JobHeader.CustomerId);
            jobHeader.Customer = customer;
            if (ModelState.IsValid)
            {
                _context.Add(jobHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobHeader);
        }

        /*
        // GET: JobHeaders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobHeader = await _context.JobHeader
                .FirstOrDefaultAsync(m => m.JobHeaderId == id);
            if (jobHeader == null)
            {
                return NotFound();
            }

            return View(jobHeader);
        }

        // GET: JobHeaders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobHeaders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobHeaderId,Name")] JobHeader jobHeader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobHeader);
        }

        // GET: JobHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobHeader = await _context.JobHeader.FindAsync(id);
            if (jobHeader == null)
            {
                return NotFound();
            }
            return View(jobHeader);
        }

        // POST: JobHeaders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobHeaderId,Name")] JobHeader jobHeader)
        {
            if (id != jobHeader.JobHeaderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobHeaderExists(jobHeader.JobHeaderId))
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
            return View(jobHeader);
        }

        // GET: JobHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobHeader = await _context.JobHeader
                .FirstOrDefaultAsync(m => m.JobHeaderId == id);
            if (jobHeader == null)
            {
                return NotFound();
            }

            return View(jobHeader);
        }

        // POST: JobHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobHeader = await _context.JobHeader.FindAsync(id);
            _context.JobHeader.Remove(jobHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobHeaderExists(int id)
        {
            return _context.JobHeader.Any(e => e.JobHeaderId == id);
        }
        */
    }
}
