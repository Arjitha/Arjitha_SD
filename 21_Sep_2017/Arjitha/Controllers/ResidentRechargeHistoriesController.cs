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
    public class ResidentRechargeHistoriesController : Controller
    {
        private readonly ArjithaContext _context;

        public ResidentRechargeHistoriesController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: ResidentRechargeHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.RHistoryCntx.ToListAsync());
        }

        // GET: ResidentRechargeHistories/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentRechargeHistory = await _context.RHistoryCntx
                .SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentRechargeHistory == null)
            {
                return NotFound();
            }

            return View(residentRechargeHistory);
        }

        // GET: ResidentRechargeHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResidentRechargeHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Resident_ID,Tran_ID,CreditRechargeDate,RechargeAmount,Remarks")] ResidentRechargeHistory residentRechargeHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residentRechargeHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(residentRechargeHistory);
        }

        // GET: ResidentRechargeHistories/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentRechargeHistory = await _context.RHistoryCntx.SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentRechargeHistory == null)
            {
                return NotFound();
            }
            return View(residentRechargeHistory);
        }

        // POST: ResidentRechargeHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Resident_ID,Tran_ID,CreditRechargeDate,RechargeAmount,Remarks")] ResidentRechargeHistory residentRechargeHistory)
        {
            if (id != residentRechargeHistory.Resident_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residentRechargeHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidentRechargeHistoryExists(residentRechargeHistory.Resident_ID))
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
            return View(residentRechargeHistory);
        }

        // GET: ResidentRechargeHistories/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentRechargeHistory = await _context.RHistoryCntx
                .SingleOrDefaultAsync(m => m.Resident_ID == id);
            if (residentRechargeHistory == null)
            {
                return NotFound();
            }

            return View(residentRechargeHistory);
        }

        // POST: ResidentRechargeHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var residentRechargeHistory = await _context.RHistoryCntx.SingleOrDefaultAsync(m => m.Resident_ID == id);
            _context.RHistoryCntx.Remove(residentRechargeHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ResidentRechargeHistoryExists(string id)
        {
            return _context.RHistoryCntx.Any(e => e.Resident_ID == id);
        }
    }
}
