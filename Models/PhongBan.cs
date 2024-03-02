using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class PhongBan
    {
        [MaxLength(20)]
        public string SoPhong {  get; set; }
        [MaxLength(100)]
        public string TenPhong { get; set; }
        [MaxLength(150)]
        public string NguoiQuanLy { get; set; }
        [MaxLength(150)]
        public string Email {  get; set; }
        [MaxLength(150)]
        public string DiaDiem { get; set; }
        [MaxLength(1000)]
        public string MoTa {  get; set; }

        // Liên kết bảng Chức vụ:
        public ICollection<ChucVu> ChucVus { get; set; }

        // Liên kết bảng Nhân viên:
        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
