﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using awprojectmodels;
using awproject.Models;
using Microsoft.Extensions.Caching.Memory;
using awprojectservices;

namespace awproject.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService _contactsService;
        private readonly IStatesService _statesService;
        private static List<State> _allStates;
        private static SelectList _statesData;
        private IMemoryCache _cache;

        public ContactsController(IContactsService contactsService, IStatesService statesService, IMemoryCache cache)
        {
            _contactsService = contactsService;
            _statesService = statesService;
            _cache = cache;
            SetAllStatesCachingData();
            _statesData = new SelectList(_allStates, "Id", "Abbreviation");
            
        }

        private void SetAllStatesCachingData()
        {
            var allStates = new List<State>();
            if (!_cache.TryGetValue(ContactCacheConstants.ALL_STATES, out allStates))
            {
                var allStatesData = Task.Run(() => _statesService.GetAllAsync()).Result;

                _cache.Set(ContactCacheConstants.ALL_STATES, allStatesData, TimeSpan.FromDays(1));
                allStates = _cache.Get(ContactCacheConstants.ALL_STATES) as List<State>;
            }
            _allStates = allStates;
        }

        private async Task UpdateStateAndResetModelState(Contact contact)
        {
            ModelState.Clear();
            var state = _allStates.SingleOrDefault(x => x.Id == contact.StateId);
            contact.State = state;
            TryValidateModel(contact);
        }

        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            var contacts = await _contactsService.GetAllAsync();
            return View(contacts);
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _contactsService.GetAsync((int)id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["StateId"] = _statesData;
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhonePrimary,PhoneSecondary,Birthday,StreetAddress1,StreetAddress2,City,Zip,StateId,UserId")] Contact contact)
        {
            await UpdateStateAndResetModelState(contact);
            if (ModelState.IsValid)
            {
                await _contactsService.AddOrUpdateAsync(contact);
                return RedirectToAction(nameof(Index));
            }
            ViewData["StateId"] = _statesData;
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _contactsService.GetAsync((int)id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["StateId"] = _statesData;
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhonePrimary,PhoneSecondary,Birthday,StreetAddress1,StreetAddress2,City,Zip,StateId,UserId")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }
            await UpdateStateAndResetModelState(contact);
            if (ModelState.IsValid)
            {
                try
                {
                    await _contactsService.AddOrUpdateAsync(contact);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await ContactExists(contact.Id))
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
            ViewData["StateId"] = _statesData;
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _contactsService.GetAsync((int)id);
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
            await _contactsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ContactExists(int id)
        {
          return await _contactsService.ExistsAsync(id);
        }
    }
}
