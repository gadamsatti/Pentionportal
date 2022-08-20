using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PensionerDetailMicroservice.Model;
using ProcessPensionMicroservice.Model;
using ProcessPensionMicroservice.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProcessPensionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProcessPensionController : Controller
    {
        IProcessPensionService processPensionService;
        static HttpClient HttpClient = new HttpClient();
        static string BaseUrl = @"https://localhost:5000/api/PensionerDetail/";

        public ProcessPensionController(IProcessPensionService processPensionService)
        {
            this.processPensionService = processPensionService;
        }

        [HttpPost]
        public async Task<ActionResult<ProcessPension>> GetProcessPensionDetail([FromBody]PensionerDetail inputpension)
        {
            try
            {
                PensionerDetail pensionerDetail = await HttpClient.GetFromJsonAsync<PensionerDetail>(BaseUrl + inputpension.Aadhar);
                ProcessPension pension = await processPensionService.GetProcessPension(pensionerDetail);

                return Ok(pension);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
