using Emergency.Areas.DarkSiteEmergency.Models;
using Emergency.Areas.MeetingRoom.Models;
using Emergency.Areas.MeetingRoom.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Controllers
{
    [Area("MeetingRoom")]//Declare Area
    public class SchedulerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public ActionResult MeetingRoom()
        {
            //  IEnumerable<Appointment> Appointments = new[] {
            //   new Appointment {
            //    AppointmentId = 2,
            //    Text = "Hop ACV",
            //    StartDate = "2022-01-18T10:00",
            //    EndDate = "2022-01-18T10:30",
            //    PriorityId = 1

            //},
            //new Appointment {
            //    AppointmentId = 3,
            //    Text = "Install New Router in Dev Room",
            //    StartDate = "2022-01-18T08:00",
            //    EndDate = "2022-01-18T09:30",
            //    PriorityId = 1
            //}
            //};
            //this.schedulerControl1.Views.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("22.00:00:00"));
            return View();
        }
        [HttpPost]
        public ActionResult MeetingRoom(string startTime,string endTime)
        {
            Appointment appointment = new Appointment()
            {
                AppointmentId = 1,
                Text = "Họp ACV",
                StartDate = startTime,
                EndDate = endTime,
                PriorityId = 1
            };
            IEnumerable<Appointment> Appointments = new[] {
               appointment

            };
            //this.schedulerControl1.Views.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("22.00:00:00"));
            return View(Appointments);
        }
        public Boolean AllowAdd()
        {
            return false;
        }
    }
}
