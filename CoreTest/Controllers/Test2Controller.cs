﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreTest.Controllers
{
    public class Test2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}