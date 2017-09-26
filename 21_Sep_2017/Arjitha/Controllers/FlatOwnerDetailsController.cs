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
    public class FlatOwnerDetailsController : Controller
    {
        private readonly ArjithaContext _context;

        public FlatOwnerDetailsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: FlatOwnerDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.FOwnerDetailsCntx.ToListAsync());
        }

        // GET: FlatOwnerDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatOwnerDetails = await _context.FOwnerDetailsCntx
                .SingleOrDefaultAsync(m => m.OwnerID == id);
            if (flatOwnerDetails == null)
            {
                return NotFound();
            }

            return View(flatOwnerDetails);
        }

        // GET: FlatOwnerDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlatOwnerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerID,OwnerFirstName,OwnerLastName,OwnerAddress,OwnerContactNumber,OwnerAlternateContactNumber,OwnerEmail,Remarks")] FlatOwnerDetails flatOwnerDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flatOwnerDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(flatOwnerDetails);
        }

        // GET: FlatOwnerDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatOwnerDetails = await _context.FOwnerDetailsCntx.SingleOrDefaultAsync(m => m.OwnerID == id);
            if (flatOwnerDetails == null)
            {
                return NotFound();
            }
            return View(flatOwnerDetails);
        }

        // POST: FlatOwnerDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OwnerID,OwnerFirstName,OwnerLastName,OwnerAddress,OwnerContactNumber,OwnerAlternateContactNumber,OwnerEmail,Remarks")] FlatOwnerDetails flatOwnerDetails)
        {
            if (id != flatOwnerDetails.OwnerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flatOwnerDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlatOwnerDetailsExists(flatOwnerDetails.OwnerID))
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
            return View(flatOwnerDetails);
        }

        // GET: FlatOwnerDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flatOwnerDetails = await _context.FOwnerDetailsCntx
                .SingleOrDefaultAsync(m => m.OwnerID == id);
            if (flatOwnerDetails == null)
            {
                return NotFound();
            }

            return View(flatOwnerDetails);
        }

        // POST: FlatOwnerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var flatOwnerDetails = await _context.FOwnerDetailsCntx.SingleOrDefaultAsync(m => m.OwnerID == id);
            _context.FOwnerDetailsCntx.Remove(flatOwnerDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FlatOwnerDetailsExists(string id)
        {
            return _context.FOwnerDetailsCntx.Any(e => e.OwnerID == id);
        }
    }
}
