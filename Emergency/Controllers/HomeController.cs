using Emergency.Models;
using Lucene.Net.Util.Cache;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ninject.Activation.Caching;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Controllers
{
    [NoCache]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Route for Login
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult Index()
        {
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["preview"])&& HttpContext.Request.Query["preview"].ToString().Equals("YES"))
            {
                return RedirectToAction("Login",
                                         "Home",
                                         new { area = "DarkSiteEmergency" });
            }
            else
            {
                HttpContext.Session.SetString("UserCode", "AUTO_WEB");
                HttpContext.Session.SetString("Password", "-_5#4eT6AF'*B6ey78#P");
                HttpContext.Session.SetString("preview", "NO");
                return RedirectToAction("Index",
                                         "Home",
                                         new { area = "DarkSiteEmergency" });

            }
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
