using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.SOA.Service.Helper;
using Microservices.SOA.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.SOA.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchController : ControllerBase
    {
        [HttpPost]
        public void Post(Order order)
        {
            EmailSender.SendEmailToDispatch(order);
        }
    }
}