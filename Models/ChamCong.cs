using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class ChamCong
    {
        [Required]
        [MaxLength(20)]
        public string MaChamCong { get; set; }
        [Required]
        public DateTime NgayChamCong {  get; set; }
        [Required]
        [MaxLength(10)]
        public string GioVaoLam { get; set; }
        [Required]
        [MaxLength(10)]
        public string GioRaLam { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ làm phải là số lớn hơn 0!")]
        public double SoGioLamViec { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ làm thêm phải là số lớn hơn 0!")]
        public double SoGioLamThem { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ nghỉ phép phải là số lớn hơn 0!")]
        public double SoGioNghiPhep { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ nghỉ không phép phải là số lớn hơn 0!")]
        public double SoGioNghiKhongPhep { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng giờ làm phải là số lớn hơn 0!")]
        public double TongGioLam {  get; set; }

        // Liên kết bảng Lịch làm:
        [MaxLength(20)]
        public string LichLamId { get; set; }
        public LichLam LichLam {  get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
