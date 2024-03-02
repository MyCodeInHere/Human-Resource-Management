using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class ChucVu
    {
        [MaxLength(20)]
        public string MaChucVu { get; set; }
        [MaxLength(100)]
        public string TenChucVu { get; set; }
        public double MucLuong {  get; set; }
        [MaxLength(1000)]
        public string MoTaCongViec { get; set; }

        // Liên kết bảng Phòng ban:
        [MaxLength(20)]
        public string PhongBanId { get; set; }
        public PhongBan PhongBan { get; set; }

        // Liên kết bảng Nhân viên:
        public ICollection<NhanVien> NhanViens { get; set;}
    }
}
