using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models
{
    public class StudentSummary
    {
        public int StuSumID { get; set; }
        public DateTime RegisterDate { get; set; }
        public string? Degree { get; set; }
        public int StudentID { get; set; }
        public int RoomNo { get; set; }
        public int MajorID { get; set; }
        public string? StudentNameKH { get; set; }
        public string? MajorNameKH { get; set; }
    }
}
