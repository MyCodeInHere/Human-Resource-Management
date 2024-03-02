using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class ChamCong
    {
        [MaxLength(20)]
        public string MaChamCong { get; set; }
        public DateTime NgayChamCong {  get; set; }
        [MaxLength(10)]
        public string GioVaoLam { get; set; }
        [MaxLength(10)]
        public string GioRaLam { get; set; }
        public double SoGioLamViec { get; set; }
        public double SoGioLamThem { get; set; }
        public double SoGioNghiPhep { get; set; }
        public double SoGioNghiKhongPhep { get; set; }
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
