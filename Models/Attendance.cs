using SFaSMS.Utils;

namespace SFaSMS.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public TimeSpan TimeRecorded { get; set; }
        public DateTime DateRecorded { get; set; }
        public bool Status { get; set; }
        public int Generation { get; set; }
        public DateTime StudyYear { get; set; }
        public string? Class { get; set; }
        public int StudentID { get; set; }
        public string? StudentNameKH { get; set; }
    }
}
