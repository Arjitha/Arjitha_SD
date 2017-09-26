using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class FlatOwnerDetails
    {
        [Key]

        [Display(Name = "Owner ID")]
        public string OwnerID { get; set; }

        [Display(Name = "Owner First Name")]

        public string OwnerFirstName { get; set; }

        [Display(Name = " Owner Last Name")]

        public string OwnerLastName { get; set; }

        [Display(Name = "Owner Address")]

        public string OwnerAddress { get; set; }

        [Display(Name = "Owner Contact Number")]

        public string OwnerContactNumber { get; set; }

        [Display(Name = "Owner Alternate Contact Number")]

        public string OwnerAlternateContactNumber { get; set; }

        [Display(Name = "Owner Email ID")]

        public string OwnerEmail { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }
    }
}
