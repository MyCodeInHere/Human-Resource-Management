using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class LichLam
    {
        [MaxLength(20)]
        public string MaLichLam {  get; set; }
        public DateTime NgayLam { get; set; }
        [MaxLength(10)]
        public string GioBatDau { get; set; }
        [MaxLength(10)]
        public string GioKetThuc { get; set; }
        [MaxLength(20)]
        public string CaLamViec { get; set; }
        [MaxLength(1000)]
        public string MoTaCongViec { get; set; }
        [MaxLength(1000)]
        public string GhiChu {  get; set; }

        // Liên kết bảng Nhân viên:
        public ICollection<LichLamNhanVien> LichLamNhanViens { get; set; }

        // Liên kết bảng Chấm công:
        public ICollection<ChamCong> ChamCongs { get; set; }

        // Liên kết bảng Nghỉ vắng:
        public ICollection<NghiVang> NghiVangs { get; set;}
    }
}
