using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class ResidentDetails
    {
        [Key]

        [Display(Name = "Resident ID")]
        public string Resident_ID { get; set; }

        [Display(Name = "Flat ID")]

        public string Flat_ID { get; set; }

        [Display(Name = " Resident First Name")]

        public string ResidentFirstName { get; set; }

        [Display(Name = "Resident Last Name")]

        public string ResidentLastName { get; set; }

        [Display(Name = "Resident Permanent Address")]

        public string ResidentPermanentAddress { get; set; }

        [Display(Name = "Resident Contact Number")]

        public string ResidentContactNumber { get; set; }


        [Display(Name = "Password")]

        public string Password { get; set; }

        [Display(Name = "Hint")]

        public string Hint { get; set; }

        [Display(Name = "Resident Alternate Contact Number")]

        public string ResidentAlternateContactNumber { get; set; }

        [Display(Name = "Service Request Credits")]

        public decimal ServiceRequestCredits { get; set; }

        [Display(Name = "Resident Gps Location")]

        public string ResidentGpsLocation { get; set; }

        [Display(Name = "Resident Email ID")]

        public string ResidentEmail { get; set; }

        [Display(Name = "Resident Occupancy Date")]

        public DateTime ResidentOccupancyDate { get; set; }

        [Display(Name = "Resident Vacated Date")]

        public DateTime ResidentVacatedDate { get; set; }

        [Display(Name = "Resident Employment Details")]

        public string ResidentEmploymentDetails { get; set; }

        [Display(Name = "Resident Identity Details")]

        public string ResidentIdentityDetails { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }
    }
}
