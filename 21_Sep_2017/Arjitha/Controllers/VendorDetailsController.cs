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
    public class VendorDetailsController : Controller
    {
        private readonly ArjithaContext _context;

        public VendorDetailsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: VendorDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.VDetailsCntx.ToListAsync());
        }

        // GET: VendorDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendorDetails = await _context.VDetailsCntx
                .SingleOrDefaultAsync(m => m.VendorID == id);
            if (vendorDetails == null)
            {
                return NotFound();
            }

            return View(vendorDetails);
        }

        // GET: VendorDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendorID,VendorType,VendorName,VendorPhoto,VendorGps,ItemsAvailable,VendorContactNumber,VendorAlternateConatactNumber,VendorEmail,VendorAddress,Password,Hint,Remarks,Rating,Govt_ID_Proof")] VendorDetails vendorDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendorDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vendorDetails);
        }

        // GET: VendorDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendorDetails = await _context.VDetailsCntx.SingleOrDefaultAsync(m => m.VendorID == id);
            if (vendorDetails == null)
            {
                return NotFound();
            }
            return View(vendorDetails);
        }

        // POST: VendorDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VendorID,VendorType,VendorName,VendorPhoto,VendorGps,ItemsAvailable,VendorContactNumber,VendorAlternateConatactNumber,VendorEmail,VendorAddress,Password,Hint,Remarks,Rating,Govt_ID_Proof")] VendorDetails vendorDetails)
        {
            if (id != vendorDetails.VendorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendorDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorDetailsExists(vendorDetails.VendorID))
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
            return View(vendorDetails);
        }

        // GET: VendorDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendorDetails = await _context.VDetailsCntx
                .SingleOrDefaultAsync(m => m.VendorID == id);
            if (vendorDetails == null)
            {
                return NotFound();
            }

            return View(vendorDetails);
        }

        // POST: VendorDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vendorDetails = await _context.VDetailsCntx.SingleOrDefaultAsync(m => m.VendorID == id);
            _context.VDetailsCntx.Remove(vendorDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VendorDetailsExists(string id)
        {
            return _context.VDetailsCntx.Any(e => e.VendorID == id);
        }
    }
}
