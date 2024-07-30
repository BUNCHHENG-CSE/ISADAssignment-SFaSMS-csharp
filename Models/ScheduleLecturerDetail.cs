using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models
{
    public class ScheduleLecturerDetail
    {
        public int ScheduleID { get; set; }
        public int LecturerID { get; set; }
        public string? LecturerNameKH { get; set; }
        public string? DaysOfTheWeek { get; set; }

    }
}
