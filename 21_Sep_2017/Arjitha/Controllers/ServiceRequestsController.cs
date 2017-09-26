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
    public class ServiceRequestsController : Controller
    {
        private readonly ArjithaContext _context;

        public ServiceRequestsController(ArjithaContext context)
        {
            _context = context;    
        }

        // GET: ServiceRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.SRequestCntx.ToListAsync());
        }

        // GET: ServiceRequests/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.SRequestCntx
                .SingleOrDefaultAsync(m => m.ServiceRequestID == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // GET: ServiceRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceRequestID,IssueDescription,ServiceRequestSatus,ServiceRequestDate,Resident_ID,ServiceRequestHandlingStatus,ServiceRequestResolvedOn,ServiceRequestLastSeen,ServiceCharges,ServiceChargesPaid,PaymentDue,VendorID,QuoteID,Remarks")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.SRequestCntx.SingleOrDefaultAsync(m => m.ServiceRequestID == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }
            return View(serviceRequest);
        }

        // POST: ServiceRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ServiceRequestID,IssueDescription,ServiceRequestSatus,ServiceRequestDate,Resident_ID,ServiceRequestHandlingStatus,ServiceRequestResolvedOn,ServiceRequestLastSeen,ServiceCharges,ServiceChargesPaid,PaymentDue,VendorID,QuoteID,Remarks")] ServiceRequest serviceRequest)
        {
            if (id != serviceRequest.ServiceRequestID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRequestExists(serviceRequest.ServiceRequestID))
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
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.SRequestCntx
                .SingleOrDefaultAsync(m => m.ServiceRequestID == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // POST: ServiceRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var serviceRequest = await _context.SRequestCntx.SingleOrDefaultAsync(m => m.ServiceRequestID == id);
            _context.SRequestCntx.Remove(serviceRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ServiceRequestExists(string id)
        {
            return _context.SRequestCntx.Any(e => e.ServiceRequestID == id);
        }
    }
}
