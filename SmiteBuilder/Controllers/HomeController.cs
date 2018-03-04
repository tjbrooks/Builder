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
        ItemSetModel ms = new ItemSetModel();
        GodSetModel gm = new GodSetModel();

        public IActionResult Index()
        {
            ViewBag.Message = "Future home of builder";
            ViewBag.Items = ms.ItemSet;
            ViewBag.Gods = gm.GodSet;
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
            return View(ms.ItemSet);
        }

        public IActionResult Gods()
        {
            ViewData["Message"] = "Browse Gods";
            return View(gm.GodSet);
        }

    }
}
