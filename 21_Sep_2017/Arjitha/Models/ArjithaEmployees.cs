using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arjitha.Models
{
    public class ArjithaEmployees
    {

        [Key]

        [Display(Name = "Employee ID")]
        public string AEID { get; set; }

        [Display(Name = "Employee Role")]

        public string Role { get; set; }

        [Display(Name = " Employee FirstName")]

        public string FirstName { get; set; }

        [Display(Name = "Employee LastName")]

        public string LastName { get; set; }

        [Display(Name = "Employee Gendar")]

        public string Gendar { get; set; }

        [Display(Name = "Employee DOJ ")]

        public System.DateTime DOJ { get; set; }

        [Display(Name = "Employee DOR")]

        public DateTime DOR { get; set; }

        [Display(Name = "Employee Prvs_Org")]

        public string Prvs_Org { get; set; }

        [Display(Name = "Employee Qualification")]

        public string Qualifications { get; set; }

        [Display(Name = "Employee DocsSubmitted")]

        public string DocsSubmitted { get; set; }

        [Display(Name = "Employee AE_WorkRating")]

        public string AE_WorkRating { get; set; }

        [Display(Name = "Employee Login ID")]

        public string LoginID { get; set; }

        [Display(Name = "Employee Password")]

        public string Password { get; set; }

        [Display(Name = "Employee Last Login")]

        public string LastLogin { get; set; }

        [Display(Name = "Employee Remarks")]

        public string Remarks { get; set; }
    }
}
