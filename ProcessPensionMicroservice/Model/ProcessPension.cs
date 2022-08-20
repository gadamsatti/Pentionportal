using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProcessPensionMicroservice.Model
{
    public class ProcessPension
    {

        [Key]
        public string Aadhar { get; set; }
        public decimal PensionAmount { get; set; }
        public decimal BankServiceCharge { get; set; }

    }
}
