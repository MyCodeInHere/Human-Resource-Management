using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class Thuong
    {
        [MaxLength(20)]
        public string MaKhoanThuong { get; set; }
        public DateTime NgayKhenThuong { get; set; }
        public double SoTienThuong { get; set; }
        [MaxLength(500)]
        public string LyDoKhenThuong { get; set; }

        // Liên kết bảng Nhân viên:
        public ICollection<ThuongNhanVien> ThuongNhanViens { get; set; }
    }
}
