﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace e_coding.gr.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult html()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult css()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult javascript()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}