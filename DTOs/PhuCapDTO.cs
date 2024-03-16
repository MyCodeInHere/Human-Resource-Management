using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class PhuCapDTO
    {
        [Required(ErrorMessage = "Mã phụ cấp không được để trống!")]
        [MaxLength(20)]
        public string MaPhuCap { get; set; }
        [Required(ErrorMessage = "Tên phụ cấp không được để trống!")]
        [MaxLength(150)]
        public string TenPhuCap { get; set; }
        [Required(ErrorMessage = "Số tiền phụ cấp không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số tiền phụ cấp phải là số lớn hơn 0!")]
        public double SoTienPhuCap { get; set; }
        [Required(ErrorMessage = "Tần suất phụ cấp không được để trống!")]
        [MaxLength(20)]
        public string TanSuat { get; set; }
        [Required(ErrorMessage = "Trạng thái phụ cấp không được để trống!")]
        [MaxLength(20)]
        public string TrangThai { get; set; }
    }
}
