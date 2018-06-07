using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Screen.Controllers
{
    [Route("Screen/[controller]")]
    public class SendMessageController : Controller
    {


        [HttpPost]
        public void SendMessage([FromBody]int messages)
        {
            HttpClient client = new HttpClient();
            for (int i = 0; i <= messages; i++)
            {
                client.PostAsync("http://api/api/Admin", new StringContent(JsonConvert.SerializeObject(messages), Encoding.UTF8, "application/json"));
            }
        }

    }
}