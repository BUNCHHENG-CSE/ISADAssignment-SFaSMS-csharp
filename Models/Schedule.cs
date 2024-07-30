using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public byte Semester { get; set; }
        public byte StudyYears { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte Session { get; set; }
        public string? Shifts { get; set; }
        public int RoomNo { get; set; }
        public int MajorID { get; set; }
        public string? MajorNameEN { get; set; }
        public Room room { get; set; } 
    }
}
