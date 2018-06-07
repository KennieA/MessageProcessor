using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpPost]
        public void SendMessage([FromBody]int messages)
        {
            HttpClient client = new HttpClient();
            client.PostAsync("http://MessageProcessor/MessageProcessor/SendMessage", new StringContent(JsonConvert.SerializeObject(messages), Encoding.UTF8, "application/json"));
        }
    }
}