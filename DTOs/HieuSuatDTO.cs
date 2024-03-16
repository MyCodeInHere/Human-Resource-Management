using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class HieuSuatDTO
    {
        [Required(ErrorMessage = "Mã hiệu suất không được để trống!")]
        [MaxLength(20)]
        public string MaHieuSuat { get; set; }
        [Required(ErrorMessage = "Người đánh giá không được để trống!")]
        [MaxLength(150)]
        public string NguoiDanhGia { get; set; }
        [Required(ErrorMessage = "Kỳ đánh giá không được để trống!")]
        [MaxLength(50)]
        public string KyDanhGia { get; set; }
        [Required(ErrorMessage = "Mục tiêu hiệu suất không được để trống!")]
        [MaxLength(200)]
        public string MucTieuHieuSuat { get; set; }
        [Required(ErrorMessage = "Đánh giá hiệu suất không được để trống!")]
        [MaxLength(200)]
        public string DanhGiaHieuSuat { get; set; }
        [Required(ErrorMessage = "Phản hồi hiệu suất không được để trống!")]
        [MaxLength(200)]
        public string PhanHoi { get; set; }
        [Required(ErrorMessage = "Kế hoạch phát triển hiệu suất không được để trống!")]
        [MaxLength(500)]
        public string KeHoachPhatTrien { get; set; }
        public string NhanVienId { get; set; }
    }
}
