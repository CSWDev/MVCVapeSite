using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCVapeSite.Models;

namespace MVCVapeSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "The Vape Store";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to Golden Vapes - Meet the team..";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
