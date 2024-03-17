using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class DotTraLuong
    {
        [Required(ErrorMessage = "Mã đợt trả lương không được để trống!")]
        [MaxLength(20)]
        public string MaDotTraLuong { get; set; }
        [Required(ErrorMessage = "Tên đợt trả lương không được để trống!")]
        [MaxLength(100)]
        public string TenDotTraLuong { get; set; }
        [Required(ErrorMessage = "Thời gian trả lương không được để trống!")]
        public DateTime ThoiGianTraLuong { get; set; }
        public int TongNhanVienCanPhaiTra { get; set; }
        public double TongTienCanPhaiTra { get; set; }
        [Required(ErrorMessage = "Người trả lương không được để trống!")]
        [MaxLength(150)]
        public string NguoiTraLuong { get; set; }
        [MaxLength(1000)]
        public string GhiChu {  get; set; }

        // Liên kết bảng trả lương nhân viên:
        public ICollection<TraLuong> TraLuongs { get; set; }
    }
}
