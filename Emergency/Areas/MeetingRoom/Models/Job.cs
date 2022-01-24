using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Models
{
    public class Job : Appointment
    {
        //public int PriorityId { get; set; }
        public int TypeId { get; set; }
        public int MeetingId { get; set; }

    }
}
