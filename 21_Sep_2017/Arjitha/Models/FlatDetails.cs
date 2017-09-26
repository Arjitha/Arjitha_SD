using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class FlatDetails
    {
        [Key]

        [Display(Name = "Flat ID")]
        public string Flat_ID { get; set; }

        [Display(Name = "Flat No")]

        public string Flat_No { get; set; }

        [Display(Name = " Floor")]

        public string Floor { get; set; }

        [Display(Name = "Block")]

        public string Block { get; set; }

        [Display(Name = "Flat Buy Date")]

        public DateTime FlatBuyDate { get; set; }

        [Display(Name = "No Of BHKs")]

        public string BHKs { get; set; }

        [Display(Name = "Current Status")]

        public string CurrentStatus { get; set; }

        [Display(Name = "Flat Incharge First Name")]

        public string FlatInchargeFirstName { get; set; }

        [Display(Name = "Flat Incharge Last Name")]

        public string FlatInchargeLastName { get; set; }

        [Display(Name = "Flat Incharge Contact Number")]

        public string FlatInchargeContactNumber { get; set; }

        [Display(Name = "Flat Incharge Alternate Contact Number")]

        public string FlatInchargeAlternateContactNumber { get; set; }

        [Display(Name = "Flat Incharge Email ID")]

        public string FlatInchargeEmail { get; set; }

        [Display(Name = "Annual Maintainace Charges")]

        public decimal AnnualMaintainaceCharges { get; set; }

        [Display(Name = "Owner ID")]

        public string OwnerID { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }
    }
}

