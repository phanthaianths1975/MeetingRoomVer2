using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Models
{
    public class MeetingRoom
    {
        public Boolean add { get; set; }
        public static Array RoomList()
        {
            return new[] {
                new { text = "Phòng họp 1 ", id = 1, color = "#fcb65e" },
                new { text = "Phòng họp 2", id = 2, color = "#e18e92" },
                new { text = "Phòng họp 3", id = 3, color = "#e18e92" }
            };
        }
        public static Boolean AllowAdd()
        {
            return false;
        }
        public static Boolean AllowDelete()
        {
            return true;
        }
        public static Boolean AllowUpdate()
        {
            return true;
        }
        //public static Boolean AllowUpdate()
        //{
        //    return true;
        //}
    }
}
