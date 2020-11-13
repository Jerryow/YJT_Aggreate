using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YJT.Web.Admin.Controllers
{
    public class MaintainController : Controller
    {
        [Route("Maintain/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
