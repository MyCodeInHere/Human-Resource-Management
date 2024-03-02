using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class NghiVang
    {
        [MaxLength(20)]
        public string MaNghiVang { get; set; }
        [MaxLength(100)]
        public string LoaiNghiVang { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc {  get; set; }
        public int SoNgayNghi {  get; set; }
        [MaxLength(1000)]
        public string LyDo {  get; set; }
        [MaxLength(50)]
        public string TrangThai { get; set; }
        [MaxLength(1000)]
        public string GhiChu { get; set; }

        // Liên kết bảng Lịch làm:
        [MaxLength(10)]
        public string LichLamId { get; set; }
        public LichLam LichLam { get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
