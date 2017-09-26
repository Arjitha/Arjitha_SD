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
    public class FlatDetailsController : Controller
    {
        private readonly ArjithaContext _context;

        public FlatDetailsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: FlatDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.FDetailsCntx.ToListAsync());
        }

        // GET: FlatDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatDetails = await _context.FDetailsCntx
                .SingleOrDefaultAsync(m => m.Flat_ID == id);
            if (flatDetails == null)
            {
                return NotFound();
            }

            return View(flatDetails);
        }

        // GET: FlatDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlatDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Flat_ID,Flat_No,Floor,Block,FlatBuyDate,BHKs,CurrentStatus,FlatInchargeFirstName,FlatInchargeLastName,FlatInchargeContactNumber,FlatInchargeAlternateContactNumber,FlatInchargeEmail,AnnualMaintainaceCharges,OwnerID,Remarks")] FlatDetails flatDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flatDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(flatDetails);
        }

        // GET: FlatDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatDetails = await _context.FDetailsCntx.SingleOrDefaultAsync(m => m.Flat_ID == id);
            if (flatDetails == null)
            {
                return NotFound();
            }
            return View(flatDetails);
        }

        // POST: FlatDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Flat_ID,Flat_No,Floor,Block,FlatBuyDate,BHKs,CurrentStatus,FlatInchargeFirstName,FlatInchargeLastName,FlatInchargeContactNumber,FlatInchargeAlternateContactNumber,FlatInchargeEmail,AnnualMaintainaceCharges,OwnerID,Remarks")] FlatDetails flatDetails)
        {
            if (id != flatDetails.Flat_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flatDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlatDetailsExists(flatDetails.Flat_ID))
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
            return View(flatDetails);
        }

        // GET: FlatDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatDetails = await _context.FDetailsCntx
                .SingleOrDefaultAsync(m => m.Flat_ID == id);
            if (flatDetails == null)
            {
                return NotFound();
            }

            return View(flatDetails);
        }

        // POST: FlatDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var flatDetails = await _context.FDetailsCntx.SingleOrDefaultAsync(m => m.Flat_ID == id);
            _context.FDetailsCntx.Remove(flatDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FlatDetailsExists(string id)
        {
            return _context.FDetailsCntx.Any(e => e.Flat_ID == id);
        }
    }
}
