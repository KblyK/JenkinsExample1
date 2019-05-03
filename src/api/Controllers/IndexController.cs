using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        public IActionResult Get()
        {
            return new OkObjectResult("Request processed by " + System.Environment.MachineName);
        }
    }
}