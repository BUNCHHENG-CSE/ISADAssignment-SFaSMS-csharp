using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models
{
    public class ScheduleSubjectDetail
    {
        public int ScheduleID { get; set; }
        public int SubjectID { get; set; }
        public string? SubjectName { get; set; }
        public string? DaysOfTheWeek { get; set; }
    }
}
