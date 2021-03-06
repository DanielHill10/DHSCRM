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
    public class ContactsController : Controller
    {
        private readonly RecordDetailContext _context;

        public ContactsController(RecordDetailContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["FirstNameSort"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //var contacts = from c in _context.Contacts select c;
            var contacts = _context.Contacts.Include(c => c.Customer).AsNoTracking();
            switch(sortOrder)
            {
                case "name_desc":
                    contacts = contacts.OrderByDescending(c => c.FirstName);
                    break;
                default:
                    contacts = contacts.OrderBy(c => c.FirstName);
                    break;
            }
            return View(await contacts.ToListAsync());
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contact == null)
            {
                return NotFound();
            }

            var contactDetailViewModel = new ContactDetailViewModel();
            contactDetailViewModel.Contact = contact;
            contactDetailViewModel.Customer = contact.Customer;

            return View(contactDetailViewModel);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            var contactDetailViewModel = new ContactDetailViewModel();
            contactDetailViewModel.Customers = _context.Customers.Select(c => new SelectListItem() { Value = c.CustomerId.ToString(), Text = c.CustomerName }).ToList();
            return View(contactDetailViewModel);
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactId,FirstName,LastName,EmailAddress,Telephone")] Contact contact, ContactDetailViewModel contactDetailViewModel)
        {
            contact.Customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == contactDetailViewModel.Customer.CustomerId);
            //Has to be a better way of doing this??? Why is it faling without... 06/03/2021
            ModelState.Remove("Customer.CustomerName");

            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                 .Include(c => c.Customer)
                 .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contact == null)
            {
                return NotFound();
            }

            var contactDetailViewModel = new ContactDetailViewModel();
            contactDetailViewModel.Contact = contact;
            contactDetailViewModel.Customer = contact.Customer;

            //Get all customers into a list variable
            //var customerList = await (from c in _context.Customers select c).ToListAsync();
            contactDetailViewModel.Customers = await _context.Customers.Select(c => new SelectListItem() { Value = c.CustomerId.ToString(), Text = c.CustomerName }).ToListAsync();

            return View(contactDetailViewModel);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactId,FirstName,LastName,EmailAddress,Telephone")] Contact contact, ContactDetailViewModel contactDetailViewModel)
        {
            contact.Customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == contactDetailViewModel.Customer.CustomerId);

            if (id != contact.ContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ContactId))
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
            return View(contactDetailViewModel);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.ContactId == id);
        }
    }
}
