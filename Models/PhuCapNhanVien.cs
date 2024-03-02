using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class PhuCapNhanVien
    {
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        [MaxLength(20)]
        public string PhuCapId { get; set; }
        public PhuCap PhuCap { get; set; }
    }
}
