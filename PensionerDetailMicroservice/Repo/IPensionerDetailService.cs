using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PensionerDetailMicroservice.Model;

namespace PensionerDetailMicroservice.Repo
{
    public interface IPensionerDetailService
    {
        Task<PensionerDetail> GetPensionerDetail(String Aadhar);
        Task<IList<PensionerDetail>> GetAllPensionerDetails();

    }
}
