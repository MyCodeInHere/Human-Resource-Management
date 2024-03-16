using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class LichLamDTO
    {
        [Required(ErrorMessage = "Mã lịch làm không được để trống!")]
        [MaxLength(20)]
        public string MaLichLam { get; set; }
        [Required(ErrorMessage = "Ngày làm không được để trống!")]
        public DateTime NgayLam { get; set; }
        [Required(ErrorMessage = "Giờ bắt đầu không được để trống!")]
        [MaxLength(10)]
        public string GioBatDau { get; set; }
        [Required(ErrorMessage = "Giờ kết thúc không được để trống!")]
        [MaxLength(10)]
        public string GioKetThuc { get; set; }
        [Required(ErrorMessage = "Ca làm không được để trống!")]
        [MaxLength(20)]
        public string CaLamViec { get; set; }
        [Required(ErrorMessage = "Mô tả công việc không được để trống!")]
        [MaxLength(1000)]
        public string MoTaCongViec { get; set; }
        [MaxLength(1000)]
        public string GhiChu { get; set; }
    }
}
