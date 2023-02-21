using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieContext _MovieContext { get; set; }

        public HomeController(MovieContext x)
        {
            _MovieContext = x;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Movies(Movie hcm)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Add(hcm);
                _MovieContext.SaveChanges();

                return View("Confirmation", hcm);
            }
            else // If Invalid
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();
                return View(hcm);
            }

      
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            var newMovie = _MovieContext.Movies.Include(x => x.Category).ToList();
            return View(newMovie);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();
            var editMovie = _MovieContext.Movies.Single(x => x.MovieId == movieid);
            return View("Movies", editMovie);
        }
        [HttpPost]
        public IActionResult Edit(Movie hcm)
        {
            _MovieContext.Update(hcm);
            _MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var delMovie = _MovieContext.Movies.Single(x => x.MovieId == movieid);
            return View(delMovie);
        }

        [HttpPost]
        public IActionResult Delete(Movie mc)
        {
            _MovieContext.Movies.Remove(mc);
            _MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
