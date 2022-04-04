using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_dot_net_dive_in_hands_on_dirty.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_dot_net_dive_in_hands_on_dirty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["hello"] = "hello";

            Students std= new Students();
            List<Students> stdList= new List<Students>();
            stdList.Add(new Students { age = 20, email = "abcd@gmail.com", id = 10, name = "Abcd" });
            std.age = 30;
            std.email = "aftab@gmail.com";
            std.id = 223;
            std.name = "aftab";
            stdList.Add(std);
            ViewData["std"] = stdList; 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
