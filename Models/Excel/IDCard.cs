using System.ComponentModel.DataAnnotations;

namespace TesterZip.Models.Excel
{
    public class IDCard
    {
        [Key]
        public int EmpId { get; set; } = 0;
        public string EmpCardType { get; set; } = "";
        public int EmpCardNumber { get; set; } = 0;
        public string EmpCardPublisher { get; set; } = "";
        public DateTime EmpCardExpired { get; set; }
        public DateTime UpdDate { get; set; }
        public string UpdUser { get; set; } = "";
        public string UpdFlag { get; set; } = "";
        public string CardDesc { get; set; } = "";
    }
}
