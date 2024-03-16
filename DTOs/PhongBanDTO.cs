using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class PhongBanDTO
    {
        [Required(ErrorMessage = "Số phòng không được để trống!")]
        [MaxLength(20)]
        public string SoPhong { get; set; }

        [Required(ErrorMessage = "Tên phòng không được để trống!")]
        [MaxLength(100)]
        public string TenPhong { get; set; }

        [MaxLength(150)]
        public string NguoiQuanLy { get; set; }

        [Required(ErrorMessage = "Email phòng không được để trống!")]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Địa điểm phòng không được để trống!")]
        [MaxLength(150)]
        public string DiaDiem { get; set; }

        [MaxLength(1000)]
        public string MoTa { get; set; }
    }
}