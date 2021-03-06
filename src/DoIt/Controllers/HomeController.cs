﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using DoIt.Data;

namespace DoIt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ActivityContext _context;

        public HomeController(ActivityContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var x = _context.Activities.ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
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
