using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using beachLake.Models;

namespace beachLake.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beach()
        {
            ViewData["Message"] = "Picture of a beach.";

            return View();
        }

        public IActionResult Lake()
        {
            ViewData["Message"] = "Picture of a Lake";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
