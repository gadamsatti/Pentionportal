using PensionerDetailMicroservice.Model;
using ProcessPensionMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Repo
{
    public interface IProcessPensionService
    {
        Task<ProcessPension> GetProcessPension(PensionerDetail pensioner);
    }
}
