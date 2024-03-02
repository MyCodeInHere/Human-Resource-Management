using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class LichLamNhanVien
    {
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        [MaxLength(20)]
        public string LichLamId { get; set; }
        public LichLam LichLam { get; set; }
    }
}
