using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class NghiVangDTO
    {
        [Required(ErrorMessage = "Mã nghỉ vắng không được để trống!")]
        [MaxLength(20)]
        public string MaNghiVang { get; set; }
        [Required(ErrorMessage = "Loại nghỉ vắng không được để trống!")]
        [MaxLength(100)]
        public string LoaiNghiVang { get; set; }
        [Required(ErrorMessage = "Ngày bắt đầu nghỉ vắng không được để trống!")]
        public DateTime NgayBatDau { get; set; }
        [Required(ErrorMessage = "Ngày kết thúc nghỉ vắng không được để trống!")]
        public DateTime NgayKetThuc { get; set; }
        [Required(ErrorMessage = "Số ngày nghỉ vắng không được để trống!")]
        public int SoNgayNghi { get; set; }
        [Required(ErrorMessage = "Lý do nghỉ vắng không được để trống!")]
        [Range(0, int.MaxValue, ErrorMessage = "Số ngày nghỉ phải là số lớn hơn 0!")]
        [MaxLength(1000)]
        public string LyDo { get; set; }
        [Required(ErrorMessage = "Trạng thái nghỉ vắng không được để trống!")]
        [MaxLength(50)]
        public string TrangThai { get; set; }
        [MaxLength(1000)]
        public string GhiChu { get; set; }
        public string LichLamId { get; set; }
        public string NhanVienId { get; set; }
    }
}
