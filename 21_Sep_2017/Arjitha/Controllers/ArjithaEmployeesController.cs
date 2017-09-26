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
    public class ArjithaEmployeesController : Controller
    {
        private readonly ArjithaContext _context;

        public ArjithaEmployeesController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: ArjithaEmployees
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArjithaEmpCntx.ToListAsync());
        }

        // GET: ArjithaEmployees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arjithaEmployees = await _context.ArjithaEmpCntx
                .SingleOrDefaultAsync(m => m.AEID == id);
            if (arjithaEmployees == null)
            {
                return NotFound();
            }

            return View(arjithaEmployees);
        }

        // GET: ArjithaEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArjithaEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AEID,Role,FirstName,LastName,Gendar,DOJ,DOR,Prvs_Org,Qualifications,DocsSubmitted,AE_WorkRating,LoginID,Password,LastLogin,Remarks")] ArjithaEmployees arjithaEmployees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arjithaEmployees);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(arjithaEmployees);
        }

        // GET: ArjithaEmployees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arjithaEmployees = await _context.ArjithaEmpCntx.SingleOrDefaultAsync(m => m.AEID == id);
            if (arjithaEmployees == null)
            {
                return NotFound();
            }
            return View(arjithaEmployees);
        }

        // POST: ArjithaEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AEID,Role,FirstName,LastName,Gendar,DOJ,DOR,Prvs_Org,Qualifications,DocsSubmitted,AE_WorkRating,LoginID,Password,LastLogin,Remarks")] ArjithaEmployees arjithaEmployees)
        {
            if (id != arjithaEmployees.AEID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arjithaEmployees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArjithaEmployeesExists(arjithaEmployees.AEID))
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
            return View(arjithaEmployees);
        }

        // GET: ArjithaEmployees/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arjithaEmployees = await _context.ArjithaEmpCntx
                .SingleOrDefaultAsync(m => m.AEID == id);
            if (arjithaEmployees == null)
            {
                return NotFound();
            }

            return View(arjithaEmployees);
        }

        // POST: ArjithaEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var arjithaEmployees = await _context.ArjithaEmpCntx.SingleOrDefaultAsync(m => m.AEID == id);
            _context.ArjithaEmpCntx.Remove(arjithaEmployees);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ArjithaEmployeesExists(string id)
        {
            return _context.ArjithaEmpCntx.Any(e => e.AEID == id);
        }
    }
}
