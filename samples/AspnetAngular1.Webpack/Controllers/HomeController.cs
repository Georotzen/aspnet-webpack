﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace AspnetAngular1.Webpack.Controllers {
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
