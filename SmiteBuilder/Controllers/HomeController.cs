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
            ItemSetModel ms = new ItemSetModel();
            return View(ms.ItemSet);
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

        public IActionResult Manage()
        {
            ViewData["Message"] = "Manage gods.";

            return View();
        }

    }
}
