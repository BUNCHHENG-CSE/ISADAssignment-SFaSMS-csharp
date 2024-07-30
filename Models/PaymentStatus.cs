using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFaSMS.Utils;

namespace SFaSMS.Models
{
    public class PaymentStatus
    {
        public int PaymentStatusID { get; set; }
        public bool SemesterOneStatus { get; set; }
        public bool SemesterTwoStatus { get; set; }
        public bool OneYearStatus { get; set; }
        public int StudentID { get; set; }
        public string? StudentNameKH { get; set; }
    }
}
