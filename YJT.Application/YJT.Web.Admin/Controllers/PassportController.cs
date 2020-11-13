using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YJT.Web.Admin.Controllers
{
    public class PassportController : Controller
    {
        [Route("Passport/login")]
        public IActionResult Login()
        {
            ViewData["Title"] = "测试";
            return View();
        }

        [Route("Passport/regist")]
        public IActionResult Regist()
        {
            return View();
        }
    }
}
