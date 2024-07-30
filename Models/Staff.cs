namespace SFaSMS.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string? StaffNameKH { get; set; }
        public string? StaffNameEN { get; set; }
        public string? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? StaffPosition { get; set; }
        public string? StaffAddress { get; set; }
        public string? ContactNumber { get; set; }
        public string? PersonalNumber { get; set; } = "";
        public DateTime? HiredDate { get; set; }
        public byte[]? Photo { get; set; } = null;
    }
}
