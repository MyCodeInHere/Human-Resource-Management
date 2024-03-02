using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class Thue
    {
        [MaxLength(20)]
        public string MaSoThue { get; set; }
        public int SoNguoiPhuThuoc {  get; set; }
        [MaxLength(50)]
        public string TrangThaiHonNhan { get; set; }
        public double MucThuNhapChiuThue { get; set; }
        public double ThueSuat { get; set; }
        public double ThueThuNhapCaNhanThucTe { get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien {  get; set; }
    }
}
