using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Arjitha.Data;
using Arjitha.Models;

namespace Arjitha.Controllers
{
    public class ResidentDetailsController : Controller
    {
        private readonly ArjithaContext _context;

        public ResidentDetailsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: ResidentDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.RDetailsCntx.ToListAsync());
        }

        // GET: ResidentDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentDetails = await _context.RDetailsCntx
                .SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentDetails == null)
            {
                return NotFound();
            }

            return View(residentDetails);
        }

        // GET: ResidentDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResidentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Resident_ID,Flat_ID,ResidentFirstName,ResidentLastName,ResidentPermanentAddress,ResidentContactNumber,Password,Hint,ResidentAlternateContactNumber,ServiceRequestCredits,ResidentGpsLocation,ResidentEmail,ResidentOccupancyDate,ResidentVacatedDate,ResidentEmploymentDetails,ResidentIdentityDetails,Remarks")] ResidentDetails residentDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residentDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(residentDetails);
        }

        // GET: ResidentDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentDetails = await _context.RDetailsCntx.SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentDetails == null)
            {
                return NotFound();
            }
            return View(residentDetails);
        }

        // POST: ResidentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Resident_ID,Flat_ID,ResidentFirstName,ResidentLastName,ResidentPermanentAddress,ResidentContactNumber,Password,Hint,ResidentAlternateContactNumber,ServiceRequestCredits,ResidentGpsLocation,ResidentEmail,ResidentOccupancyDate,ResidentVacatedDate,ResidentEmploymentDetails,ResidentIdentityDetails,Remarks")] ResidentDetails residentDetails)
        {
            if (id != residentDetails.Resident_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residentDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidentDetailsExists(residentDetails.Resident_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(residentDetails);
        }

        // GET: ResidentDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentDetails = await _context.RDetailsCntx
                .SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentDetails == null)
            {
                return NotFound();
            }

            return View(residentDetails);
        }

        // POST: ResidentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var residentDetails = await _context.RDetailsCntx.SingleOrDefaultAsync(m => m.Resident_ID == id);
            _context.RDetailsCntx.Remove(residentDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ResidentDetailsExists(string id)
        {
            return _context.RDetailsCntx.Any(e => e.Resident_ID == id);
        }
    }
}
