using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Models
{
    public class ResidentRechargeHistory
    {
        [Key]

        [Display(Name = "Resident ID")]

        public string Resident_ID { get; set; }

        [Display(Name = "Transaction ID")]

        public string Tran_ID { get; set; }

        [Display(Name = "Credit Recharge Date")]

        public DateTime CreditRechargeDate { get; set; }

        [Display(Name = "Recharge Amount")]

        public decimal RechargeAmount { get; set; }

        [Display(Name = "Remarks")]

        public string Remarks { get; set; }
    }
}
