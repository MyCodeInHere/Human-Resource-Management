using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class NhanVienDTO
    {
        [Required(ErrorMessage = "Mã nhân viên không được để trống!")]
        [MaxLength(20)]
        public string MaNhanVien { get; set; }
        [Required(ErrorMessage = "Họ tên nhân viên không được để trống!")]
        [MaxLength(150)]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Ngày sinh nhân viên không được để trống!")]
        public DateTime NgaySinh { get; set; }
        [Required(ErrorMessage = "Giới tính nhân viên không được để trống!")]
        [MaxLength(6)]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Căn cước của nhân viên không được để trống!")]
        [MaxLength(12)]
        public string Cccd { get; set; }
        [MaxLength(50)]
        public string TonGiao { get; set; }
        [MaxLength(150)]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Số điện thoại nhân viên không được để trống!")]
        [MaxLength(11)]
        public string SoDienThoai { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ngày nhân viên vào làm không được để trống!")]
        public DateTime NgayVaoLam { get; set; }
        [MaxLength(150)]
        public string NguoiQuanLy { get; set; }
        [Required(ErrorMessage = "Mức lương cơ bản của nhân viên không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Lương cơ bản của nhân viên phải là số lớn hơn 0!")]
        public double MucLuong { get; set; }
        [Required(ErrorMessage = "Trạng thái làm của nhân viên không được để trống!")]
        [MaxLength(20)]
        public string TrangThai { get; set; }
        public string PhongBanId { get; set; }
        public string ChucVuId { get; set; }
    }
}
