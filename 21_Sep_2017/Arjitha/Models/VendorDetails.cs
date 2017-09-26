using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class VendorDetails
    {
        [Key]

        [Display(Name = "Vendor ID")]

        public string VendorID { get; set; }

        [Display(Name = "Vendor Type")]

        public string VendorType { get; set; }

        [Display(Name = "Vendor Name")]

        public string VendorName { get; set; }

        [Display(Name = "Vendor Photograph")]

        public string VendorPhoto { get; set; }

        [Display(Name = "Vendor Gps")]

        public string VendorGps { get; set; }

        [Display(Name = "Items Available")]

        public string ItemsAvailable { get; set; }

        [Display(Name = "Vendor Contact Number")]

        public string VendorContactNumber { get; set; }

        [Display(Name = "Vendor Alternate ContactNo")]

        public string VendorAlternateConatactNumber { get; set; }

        [Display(Name = "Vendor Email")]

        public string VendorEmail { get; set; }

        [Display(Name = "Vendor Address")]

        public string VendorAddress { get; set; }

        [Display(Name = "Password")]

        public string Password { get; set; }

        [Display(Name = "Hint")]

        public string Hint { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }

        [Display(Name = "Rating")]

        public int Rating { get; set; }

        [Display(Name = "Govt ID Proof")]

        public string Govt_ID_Proof { get; set; }
    }
}
