using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class TraLuong
    {
        [Required(ErrorMessage = "Mã trả lương không được để trống!")]
        [MaxLength(20)]
        public string MaTraLuong { get; set; }
        [Required(ErrorMessage = "Trạng thái trả lương không được để trống!")]
        [MaxLength(20)]
        public string TrangThai { get; set; }
        public double SoTienCanPhaiTra { get; set; }
        public double SoTienDaTra { get; set; }
        public double SoTienConPhaiTra { get; set; }
        [Required(ErrorMessage = "Ngày trả lương không được để trống!")]
        public DateTime NgayTraLuong { get; set; }
        [MaxLength(1000)]
        public string GhiChu {  get; set; }

        // Liên kết bảng nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }

        // Liên kết bảng đợt trả lương:
        [MaxLength(20)]
        public string DotTraLuongId { get; set; }
        public DotTraLuong DotTraLuong { get; set; }
    }
}
