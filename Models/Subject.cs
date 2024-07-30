using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models;

public class Subject
{
    public int SubjectID { get; set; }  
    public string? SubjectName { get; set; }
    public string SubjectDescription { get; set; } = null;
}
