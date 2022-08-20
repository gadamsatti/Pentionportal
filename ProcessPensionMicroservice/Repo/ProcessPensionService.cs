using ProcessPensionMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PensionerDetailMicroservice.Model;
using System.Net.Http;

namespace ProcessPensionMicroservice.Repo
{
    public class ProcessPensionService : IProcessPensionService
    {
        
        public async Task<ProcessPension> GetProcessPension(PensionerDetail pensioner)
        {
            ProcessPension processPension = new ProcessPension();
            var db = new PentionDb();

            processPension.Aadhar = pensioner.Aadhar;

            


            if (pensioner.PensionType == 0)
            {
                processPension.PensionAmount = (decimal)0.8 * pensioner.SalaryEarned + pensioner.Allowances;
            }
            else
            {
                processPension.PensionAmount = (decimal)0.5 * pensioner.SalaryEarned + pensioner.Allowances;
            }


            if(pensioner.BankType == 0)
            {
                processPension.BankServiceCharge = (decimal)500;
            }
            else
            {
                processPension.BankServiceCharge = (decimal)550;
            }



            if(await db.ProcessPensions.FindAsync(processPension.Aadhar) == null)
            {
                await db.ProcessPensions.AddAsync(processPension);
                await db.SaveChangesAsync();
            }

            return processPension;
        }
    }
}
