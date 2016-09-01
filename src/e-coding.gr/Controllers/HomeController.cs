using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace e_coding.gr.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult css()
        {
            ViewData["Message"] = "Φροντιστήριο για CSS.";

            return View();
        }

        public IActionResult javascript()
        {
            ViewData["Message"] = "Φροντιστήριο για JavaScript";

            return View();
        }

        public IActionResult about()
        {
            ViewData["Message"] = "Ποιοι είμαστε;";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        [Authorize]
        public IActionResult account()
        {
            return View();
        }
    }
}
