using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission07.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext x)
        {
            _logger = logger;
            _MovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movies(HomeControllerModel hcm)
        {
            _MovieContext.Add(hcm);
            _MovieContext.SaveChanges();

            return View("Confirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
