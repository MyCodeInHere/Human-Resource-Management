using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class HopDongDTO
    {
        [Required(ErrorMessage = "Mã hợp đồng không được để trống!")]
        [MaxLength(20)]
        public string MaHopDong { get; set; }
        [Required(ErrorMessage = "Loại hợp đồng không được để trống!")]
        [MaxLength(100)]
        public string LoaiHopDong { get; set; }
        [Required(ErrorMessage = "Ngày bắt đầu hợp đồng không được để trống!")]
        public DateTime NgayBatDau { get; set; }
        [Required(ErrorMessage = "Ngày kết thúc hợp đồng không được để trống!")]
        public DateTime NgayKetThuc { get; set; }
        [Required(ErrorMessage = "Thời hạn hợp đồng không được để trống!")]
        [MaxLength(20)]
        public string ThoiHanHopDong { get; set; }
        [Required(ErrorMessage = "Nội dung hợp đồng không được để trống!")]
        [MaxLength(1000)]
        public string NoiDungHopDong { get; set; }
        [Required(ErrorMessage = "Trạng thái hợp đồng không được để trống!")]
        [MaxLength(50)]
        public string TrangThaiHopDong { get; set; }
        [Required(ErrorMessage = "Ngày ký hợp đồng không được để trống!")]
        public DateTime NgayKy { get; set; }
        [MaxLength(500)]
        public string GhiChu { get; set; }
        public string NhanVienId { get; set; }
    }
}
