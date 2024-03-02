using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class PhuCap
    {
        [MaxLength(20)]
        public string MaPhuCap { get; set; }
        [MaxLength(150)]
        public string TenPhuCap {  get; set; }
        public double SoTienPhuCap { get; set; }
        [MaxLength(20)]
        public string TanSuat {  get; set; }
        [MaxLength(20)]
        public string TrangThai {  get; set; }

        // Liên kết bảng Nhân viên:
        public ICollection<PhuCapNhanVien> PhuCapNhanViens { get; set; }
    }
}
