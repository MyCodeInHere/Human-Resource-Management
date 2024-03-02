using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class ThuongNhanVien
    {
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        [MaxLength(20)]
        public string ThuongId { get; set; }
        public Thuong Thuong { get; set; }
    }
}
