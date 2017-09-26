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
    public class ServiceRequestChildsController : Controller
    {
        private readonly ArjithaContext _context;

        public ServiceRequestChildsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: ServiceRequestChilds
        public async Task<IActionResult> Index()
        {
            return View(await _context.SRequestChildCntx.ToListAsync());
        }

        // GET: ServiceRequestChilds/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequestChild = await _context.SRequestChildCntx
                .SingleOrDefaultAsync(m => m.ServiceRequest_ID == id);
            if (serviceRequestChild == null)
            {
                return NotFound();
            }

            return View(serviceRequestChild);
        }

        // GET: ServiceRequestChilds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceRequestChilds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceRequest_ID,HandyMan_ID,ServiceRequestImage,ServiceRequestDesc,ServiceRequestStatus,ServiceRequestStartDate,ServiceRequestEndDate,Remarks")] ServiceRequestChild serviceRequestChild)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceRequestChild);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(serviceRequestChild);
        }

        // GET: ServiceRequestChilds/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequestChild = await _context.SRequestChildCntx.SingleOrDefaultAsync(m => m.ServiceRequest_ID == id);
            if (serviceRequestChild == null)
            {
                return NotFound();
            }
            return View(serviceRequestChild);
        }

        // POST: ServiceRequestChilds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ServiceRequest_ID,HandyMan_ID,ServiceRequestImage,ServiceRequestDesc,ServiceRequestStatus,ServiceRequestStartDate,ServiceRequestEndDate,Remarks")] ServiceRequestChild serviceRequestChild)
        {
            if (id != serviceRequestChild.ServiceRequest_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceRequestChild);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRequestChildExists(serviceRequestChild.ServiceRequest_ID))
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
            return View(serviceRequestChild);
        }

        // GET: ServiceRequestChilds/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequestChild = await _context.SRequestChildCntx
                .SingleOrDefaultAsync(m => m.ServiceRequest_ID == id);
            if (serviceRequestChild == null)
            {
                return NotFound();
            }

            return View(serviceRequestChild);
        }

        // POST: ServiceRequestChilds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var serviceRequestChild = await _context.SRequestChildCntx.SingleOrDefaultAsync(m => m.ServiceRequest_ID == id);
            _context.SRequestChildCntx.Remove(serviceRequestChild);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ServiceRequestChildExists(string id)
        {
            return _context.SRequestChildCntx.Any(e => e.ServiceRequest_ID == id);
        }
    }
}
