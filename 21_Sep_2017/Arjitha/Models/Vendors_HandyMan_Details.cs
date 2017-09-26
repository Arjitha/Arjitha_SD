using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class Vendors_HandyMan_Details
    {
        [Key]

        [Display(Name = "Handyman ID")]

        public string HandyMan_ID { get; set; }

        [Display(Name = "Vendor ID")]

        public string VendorID { get; set; }

        [Display(Name = "HandyMan First Name")]

        public string HandyMan_FirstName { get; set; }

        [Display(Name = "HandyMan Last Name")]

        public string HandyMan_LastName { get; set; }

        [Display(Name = "Primary Contact No")]

        public string PrimaryContactNo { get; set; }

        [Display(Name = "Secondary Conatact No")]

        public string SecondaryContactNo { get; set; }

        [Display(Name = "Address")]

        public string Address { get; set; }

        [Display(Name = "Gender")]

        public string Gender { get; set; }

        [Display(Name = "DOJ")]

        public DateTime DOJ { get; set; }

        [Display(Name = "DOR")]

        public DateTime DOR { get; set; }

        [Display(Name = "Experties")]

        public string Experties { get; set; }

        [Display(Name = "Previous Organisation")]

        public string Prvs_Org { get; set; }

        [Display(Name = "Govt ID Proof")]

        public string Govt_ID_Proof { get; set; }

        [Display(Name = "Docs Submitted")]

        public string DocsSubmitted { get; set; }

        [Display(Name = "Rating")]

        public int Rating { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }

        [Display(Name = "Photograph")]

        public string Photograph { get; set; }


    }
}
