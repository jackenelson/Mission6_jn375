using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;

        private AppContext _blahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, AppContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index1()
        {
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
            return View("Index1");
        }
        public IActionResult Privacy()
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
