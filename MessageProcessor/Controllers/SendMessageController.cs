using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageProcessor.Controllers
{
    [Route("MessageProcessor/[controller]")]
    public class SendMessageController : Controller
    {
        public void SendMessage([FromBody]int messages)
        {
            for (int i = 0; i <= messages; i++)
            {
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}