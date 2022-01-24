using Emergency.Areas.MeetingRoom.Models.SampleData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.DarkSiteEmergency.Controllers
{
    public class SchedulerController : Controller
    {
        // GET: SchedulerController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: SchedulerController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SchedulerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchedulerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchedulerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchedulerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchedulerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchedulerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult MeetingRoom()
        {
            //this.schedulerControl1.Views.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("22.00:00:00"));
            return View(SampleData.JobAppointments);
        }


    }
}
