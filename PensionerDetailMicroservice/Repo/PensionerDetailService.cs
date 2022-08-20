using CsvHelper;
using PensionerDetailMicroservice.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionerDetailMicroservice.Repo
{
    public class PensionerDetailService : IPensionerDetailService
    {
        List<PensionerDetail> pensionerDetails;

        public PensionerDetailService()
        {
            TextReader reader = new StreamReader("../PensionerDetailData.csv");
            var csvReader = new CsvReader(reader, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            pensionerDetails = csvReader.GetRecords<PensionerDetail>().ToList();

        }
        public async Task<IList<PensionerDetail>> GetAllPensionerDetails()
        {
            return pensionerDetails;
        }

        public async Task<PensionerDetail> GetPensionerDetail(string Aadhar)
        {
            PensionerDetail pensioner = pensionerDetails.Find(ob => ob.Aadhar == Aadhar);
            return pensioner;
        }
    }
}
