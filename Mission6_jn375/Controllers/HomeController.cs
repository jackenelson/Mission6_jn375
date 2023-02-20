using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_jn375.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppContext = Mission6_jn375.Models.AppContext;

namespace Mission6_jn375.Controllers
{
    public class HomeController : Controller
    {
        

        private AppContext _blahContext { get; set; }
        public HomeController(AppContext someName)
        {
          
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index1()
        {
            ViewBag.Categories = _blahContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Index1(ModelClass ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("Index2", ar);
            }
            else
            {
                ViewBag.Categories = _blahContext.Categories.ToList();
                return View();
            }
            
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index3()
        {
            var apps = _blahContext.MovieInputs
                .Include(x => x.Category)
                //.Where( x => x.Edited == false)
                .OrderBy(x => x.Title)
                .ToList();
            return View(apps);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _blahContext.Categories.ToList();

            var application = _blahContext.MovieInputs.Single(x => x.MovieId == movieid);
            return View("Index1", application);
        }

        [HttpPost]
        public IActionResult Edit(ModelClass blah)
        {
            _blahContext.Update(blah);
            _blahContext.SaveChanges();
            return RedirectToAction("Index3");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = _blahContext.MovieInputs.Single(x => x.MovieId == movieid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ModelClass ar)
        {
            _blahContext.Remove(ar);
            _blahContext.SaveChanges();
            return RedirectToAction("Index3");
        }

    }
}
