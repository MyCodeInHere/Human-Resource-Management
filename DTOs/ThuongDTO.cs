using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class ThuongDTO
    {
        [Required(ErrorMessage = "Mã khoản thưởng không được để trống!")]
        [MaxLength(20)]
        public string MaKhoanThuong { get; set; }
        [Required(ErrorMessage = "Ngày khen thưởng không được để trống!")]
        public DateTime NgayKhenThuong { get; set; }
        [Required(ErrorMessage = "Số tiền thưởng không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số tiền thưởng phải là số lớn hơn 0!")]
        public double SoTienThuong { get; set; }
        [Required(ErrorMessage = "Lý do khen thưởng không được để trống!")]
        [MaxLength(500)]
        public string LyDoKhenThuong { get; set; }
    }
}
