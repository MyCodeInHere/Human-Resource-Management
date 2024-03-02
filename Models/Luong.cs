using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class Luong
    {
        [MaxLength(20)]
        public string MaLuong {  get; set; }
        public double LuongCoBan { get; set; }
        public double TongTienPhuCap { get; set; }
        public double TongTienThuong { get; set; }
        public double TongTien {  get; set; }
        public double CacKhoanKhauTru { get; set; }
        public double ThuNhapRong {  get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
