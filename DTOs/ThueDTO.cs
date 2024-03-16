using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class ThueDTO
    {
        [Required(ErrorMessage = "Mã số thuế không được để trống!")]
        [MaxLength(20)]
        public string MaSoThue { get; set; }
        [Required(ErrorMessage = "Số người phụ thuộc không được để trống!")]
        public int SoNguoiPhuThuoc { get; set; }
        [Required(ErrorMessage = "Trạng thái hôn nhân không được để trống!")]
        [MaxLength(50)]
        public string TrangThaiHonNhan { get; set; }
        [Required(ErrorMessage = "Mức thu nhập chịu thuế không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Mức thu nhập chịu thuế phải là số lớn hơn hoặc bằng 0!")]
        public double MucThuNhapChiuThue { get; set; }
        [Required(ErrorMessage = "Thuế suất không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Thuế suất phải là số lớn hơn hoặc bằng 0!")]
        public double ThueSuat { get; set; }
        [Required(ErrorMessage = "Thuế thu nhập cá nhân thực tế không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Thuế thu nhập cá nhân thực tế phải là số lớn hơn hoặc bằng  0!")]
        public double ThueThuNhapCaNhanThucTe { get; set; }
        public string NhanVienId { get; set; }
    }
}
