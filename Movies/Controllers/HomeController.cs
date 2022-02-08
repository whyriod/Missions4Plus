using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context { get; set; }

        public HomeController(MovieContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var record = _context.Movies.Single(x => x.MovieId == id);
            return View("MovieDelete",record);
        }

        [HttpPost]
        public IActionResult Delete(MovieModel m)
        {
            _context.Movies.Remove(m);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var record = _context.Movies.Single(x => x.MovieId == id);
            return View("MovieEntry", record);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel movie)
        {
            if(ModelState.IsValid)
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(movie);
            }
        }



        [HttpGet]
        public IActionResult MovieEntry()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View(new MovieModel());
        }

        [HttpPost]
        public IActionResult MovieEntry(MovieModel m)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m);
                _context.SaveChanges();
                return View("Submitted", m);
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(m);
            }
        }



        public IActionResult MovieList()
        {
            var movies = _context.Movies.Include(X => X.Category).ToList();
            return View(movies);
        }

    }
}
