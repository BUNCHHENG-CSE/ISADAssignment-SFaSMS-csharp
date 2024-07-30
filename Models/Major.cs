using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models;

public class Major
{
    public int MajorID { get; set; }
    public string? MajorNameKH { get; set; }
    public string? MajorNameEN { get; set; }
    public string? MajorNameAbbreviation { get; set; }
    public decimal MajorCost { get; set; }
    public string? MajorDescription { get; set; }
}
