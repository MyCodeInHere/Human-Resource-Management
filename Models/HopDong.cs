using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class HopDong
    {
        [MaxLength(20)]
        public string MaHopDong {  get; set; }
        [MaxLength(100)]
        public string LoaiHopDong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc {  get; set; }
        [MaxLength(20)]
        public string ThoiHanHopDong { get; set; }
        [MaxLength(1000)]
        public string NoiDungHopDong { get; set; }
        [MaxLength(50)]
        public string TrangThaiHopDong { get; set; }
        public DateTime NgayKy {  get; set; }
        [MaxLength(500)]
        public string GhiChu {  get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
