
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class ServiceRequest
    {
        [Key]

        [Display(Name = "Service Request ID")]

        public string ServiceRequestID { get; set; }

        [Display(Name = "Issue Description")]

        public string IssueDescription { get; set; }

        [Display(Name = "Service Request Status")]

        public string ServiceRequestSatus { get; set; }

        [Display(Name = "Service Request Date")]

        public DateTime ServiceRequestDate { get; set; }

        [Display(Name = "Resident ID")]

        public string Resident_ID { get; set; }

        [Display(Name = "Service Request Handling Status")]

        public string ServiceRequestHandlingStatus { get; set; }

        [Display(Name = "Service Request Resolved On")]

        public string ServiceRequestResolvedOn { get; set; }

        [Display(Name = "Service Request Last Seen")]

        public string ServiceRequestLastSeen { get; set; }

        [Display(Name = "Service Charges")]

        public decimal ServiceCharges { get; set; }

        [Display(Name = "Service Charges Paid")]

        public decimal ServiceChargesPaid { get; set; }

        [Display(Name = "Payment Due")]

        public DateTime PaymentDue { get; set; }

        [Display(Name = "Vendor ID")]

        public string VendorID { get; set; }

        [Display(Name = "Quote ID")]

        public string QuoteID { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }



    }
}
