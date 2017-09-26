using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{

    public class ServiceRequestChild
    {
        [Key]

        [Display(Name = "Service Request ID")]

        public string ServiceRequest_ID { get; set; }

        [Display(Name = "HandyMan ID")]

        public string HandyMan_ID { get; set; }

        [Display(Name = "Service Request Image")]

        public string ServiceRequestImage { get; set; }

        [Display(Name = "Service Request Desc")]

        public string ServiceRequestDesc { get; set; }

        [Display(Name = "Service Request Status")]

        public string ServiceRequestStatus { get; set; }

        [Display(Name = "Service Request Start Date")]

        public DateTime ServiceRequestStartDate { get; set; }

        [Display(Name = "Service Request End Date")]

        public DateTime ServiceRequestEndDate { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }



    }
}

