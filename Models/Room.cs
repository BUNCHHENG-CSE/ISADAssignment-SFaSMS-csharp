using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Models;

public class Room
{
    public int RoomNo { get; set; }
    public int RoomNumber { get; set; }
    public string? BuildingLetter { get; set; }
}
