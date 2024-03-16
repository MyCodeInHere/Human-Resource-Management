using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class ChucVuDTO
    {
        [Required(ErrorMessage = "Mã chức vụ không được để trống!")]
        [MaxLength(20)]
        public string MaChucVu { get; set; }
        [Required(ErrorMessage = "Tên chức vụ không được để trống!")]
        [MaxLength(100)]
        public string TenChucVu { get; set; }
        [Required(ErrorMessage = "Mức lương chức vụ không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Mức lương phải là số lớn hơn 0!")]
        public double MucLuong { get; set; }
        [MaxLength(1000)]
        public string MoTaCongViec { get; set; }
        public string PhongBanId { get; set; }
    }
}
