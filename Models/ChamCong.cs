using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class ChamCong
    {
        [Required(ErrorMessage = "Mã chấm công không được để trống!")]
        [MaxLength(20)]
        public string MaChamCong { get; set; }
        [Required(ErrorMessage = "Ngày chấm công không được để trống!")]
        public DateTime NgayChamCong {  get; set; }
        [Required(ErrorMessage = "Giờ vào làm không được để trống!")]
        [MaxLength(10)]
        public string GioVaoLam { get; set; }
        [Required(ErrorMessage = "Giờ ra làm không được để trống!")]
        [MaxLength(10)]
        public string GioRaLam { get; set; }
        [Required(ErrorMessage = "Giờ ra làm không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ làm phải là số lớn hơn 0!")]
        public double SoGioLamViec { get; set; }
        [Required(ErrorMessage = "Số giờ làm không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ làm thêm phải là số lớn hơn 0!")]
        public double SoGioLamThem { get; set; }
        [Required(ErrorMessage = "Số giờ làm thêm không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ nghỉ phép phải là số lớn hơn 0!")]
        public double SoGioNghiPhep { get; set; }
        [Required(ErrorMessage = "Số giờ nghỉ phép không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Số giờ nghỉ không phép phải là số lớn hơn 0!")]
        public double SoGioNghiKhongPhep { get; set; }
        [Required(ErrorMessage = "Số giờ nghỉ không được để trống!")]
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
