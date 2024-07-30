using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models;

public class Lecturer
{  
    public int LecturerID { get; set; }       
    public string? LecturerNameKH { get; set; }
    public string? LecturerNameEN { get; set; }     
    public string? Gender { get; set; }  
    public DateTime BirthDate { get; set; } 
    public string? LecturerAddress { get; set; }
    public string? ContactNumber { get; set; }
    public string? PersonalNumber { get; set; }
    public byte[]? Photo { get; set; } = null;
}
