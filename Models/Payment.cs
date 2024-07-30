namespace SFaSMS.Models
{
    public class Payment
    {
        public int PaymentNo { get; set; }
        public DateTime PayDate { get; set; }
        public decimal PaidAmount { get; set; }
        public int PaymentStatusID { get; set; }
        public int StaffID { get; set; }
        public int MajorID { get; set; }
        public string? StaffNameKH { get; set; }
        public string? StaffPosition { get; set; }
        public decimal MajorCost { get; set; }
        public Student? student{get; set;}
    }
}
