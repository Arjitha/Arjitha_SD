using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class ServiceRequestQuotation
    {
        [Key]

        [Display(Name = "Quote ID")]

        public string QuoteID { get; set; }

        [Display(Name = "Service Request ID")]

        public string ServiceRequest_ID { get; set; }

        [Display(Name = "Quote Image")]

        public string QuoteImage { get; set; }

        [Display(Name = "Estimated Quote")]

        public int EstimatedQuote { get; set; }

        [Display(Name = "Vendor ID")]

        public string VendorID { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }


    }
}