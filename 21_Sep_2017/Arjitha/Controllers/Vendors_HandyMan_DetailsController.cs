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
    public class Vendors_HandyMan_DetailsController : Controller
    {
        private readonly ArjithaContext _context;

        public Vendors_HandyMan_DetailsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: Vendors_HandyMan_Details
        public async Task<IActionResult> Index()
        {
            return View(await _context.VHandyManDetailsCntx.ToListAsync());
        }

        // GET: Vendors_HandyMan_Details/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors_HandyMan_Details = await _context.VHandyManDetailsCntx
                .SingleOrDefaultAsync(m => m.HandyMan_ID == id);
            if (vendors_HandyMan_Details == null)
            {
                return NotFound();
            }

            return View(vendors_HandyMan_Details);
        }

        // GET: Vendors_HandyMan_Details/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors_HandyMan_Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HandyMan_ID,VendorID,HandyMan_FirstName,HandyMan_LastName,PrimaryContactNo,SecondaryContactNo,Address,Gender,DOJ,DOR,Experties,Prvs_Org,Govt_ID_Proof,DocsSubmitted,Rating,Remarks,Photograph")] Vendors_HandyMan_Details vendors_HandyMan_Details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendors_HandyMan_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vendors_HandyMan_Details);
        }

        // GET: Vendors_HandyMan_Details/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors_HandyMan_Details = await _context.VHandyManDetailsCntx.SingleOrDefaultAsync(m => m.HandyMan_ID == id);
            if (vendors_HandyMan_Details == null)
            {
                return NotFound();
            }
            return View(vendors_HandyMan_Details);
        }

        // POST: Vendors_HandyMan_Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HandyMan_ID,VendorID,HandyMan_FirstName,HandyMan_LastName,PrimaryContactNo,SecondaryContactNo,Address,Gender,DOJ,DOR,Experties,Prvs_Org,Govt_ID_Proof,DocsSubmitted,Rating,Remarks,Photograph")] Vendors_HandyMan_Details vendors_HandyMan_Details)
        {
            if (id != vendors_HandyMan_Details.HandyMan_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendors_HandyMan_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Vendors_HandyMan_DetailsExists(vendors_HandyMan_Details.HandyMan_ID))
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
            return View(vendors_HandyMan_Details);
        }

        // GET: Vendors_HandyMan_Details/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors_HandyMan_Details = await _context.VHandyManDetailsCntx
                .SingleOrDefaultAsync(m => m.HandyMan_ID == id);
            if (vendors_HandyMan_Details == null)
            {
                return NotFound();
            }

            return View(vendors_HandyMan_Details);
        }

        // POST: Vendors_HandyMan_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vendors_HandyMan_Details = await _context.VHandyManDetailsCntx.SingleOrDefaultAsync(m => m.HandyMan_ID == id);
            _context.VHandyManDetailsCntx.Remove(vendors_HandyMan_Details);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Vendors_HandyMan_DetailsExists(string id)
        {
            return _context.VHandyManDetailsCntx.Any(e => e.HandyMan_ID == id);
        }
    }
}
