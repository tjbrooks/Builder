using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmiteBuilder.Models;

namespace SmiteBuilder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Future home of builder";
            return View();            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Items()
        {
            ViewData["Message"] = "Browse Items";
            ItemSetModel ms = new ItemSetModel();
            return View(ms.ItemSet);
        }

        public IActionResult Gods()
        {
            ViewData["Message"] = "Browse Gods";
            GodSetModel gm = new GodSetModel();
            return View(gm.GodSet);
        }

    }
}
