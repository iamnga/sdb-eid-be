using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using sdb_eid_be.Models;

namespace sdb_eid_be.Controllers
{
    
    [ApiController]
    public class AioController : ControllerBase
    {
        [Route("[controller]/upload-image")]
        [HttpPost]
        public async Task<object> UploadImage(AllInOneRequest req)
        {
            var reqJSON = JsonConvert.SerializeObject(req);

            var client = new HttpClient();
            var response = await client.PostAsync("https://cardtest.sacombank.com.vn:9443/digizone/upload-image", new StringContent(reqJSON, Encoding.UTF8, "application/json"));
            var contents = await response.Content.ReadAsStringAsync();
            return contents;
        }
    }
}
