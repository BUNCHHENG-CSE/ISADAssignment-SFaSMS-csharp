using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models;


public class Student
{ 
    public int StudentID { get; set; }     
    public string? StudentNameKH { get; set; }
    public string? StudentNameEN { get; set; }        
    public string? Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string? StudentAddress { get; set; }
    public string? PersonalNumber { get; set; }     
    public string? ParentNumber { get; set; }
    public byte[]? Photo { get; set; } = null;
}
