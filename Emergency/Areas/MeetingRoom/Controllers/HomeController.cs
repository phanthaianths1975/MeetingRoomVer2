using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Controllers
{
    [Area("MeetingRoom")]//Declare Area
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(int id)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("MeetingRoom", "Scheduler", new { area = "MeetingRoom" });
            }
            return View();
        }
    }
}
