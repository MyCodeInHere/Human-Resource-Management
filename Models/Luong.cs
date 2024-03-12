using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class Luong
    {
        [Required(ErrorMessage = "Mã lương không được để trống!")]
        [MaxLength(20)]
        public string MaLuong {  get; set; }
        [Required(ErrorMessage = "Lương cơ bản không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Lương cơ bản phải là số lớn hơn 0!")]
        public double LuongCoBan { get; set; }
        [Required(ErrorMessage = "Tổng tiền phụ cấp không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền phụ cấp phải là số lớn hơn 0!")]
        public double TongTienPhuCap { get; set; }
        [Required(ErrorMessage = "Tổng tiền thưởng không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền thưởng phải là số lớn hơn 0!")]
        public double TongTienThuong { get; set; }
        [Required(ErrorMessage = "Tổng tiền không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền phải là số lớn hơn 0!")]
        public double TongTien {  get; set; }
        [Required(ErrorMessage = "Các khoản khấu trừ không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Các khoản khấu trừ phải là số lớn hơn 0!")]
        public double CacKhoanKhauTru { get; set; }
        [Required(ErrorMessage = "Thu nhập ròng không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Thu nhập ròng phải là số lớn hơn 0!")]
        public double ThuNhapRong {  get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
