using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Admin.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // POST: Admin
        public void SendMessage()
        {
            HttpClient client = new HttpClient();
            client.PostAsync("http://api/api/MessageProcessor", new StringContent(JsonConvert.SerializeObject(10), Encoding.UTF8, "application/json"));
        }
    }
}