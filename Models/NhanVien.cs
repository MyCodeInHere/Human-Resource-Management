using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HumanResourceManagement.Models
{
    public class NhanVien
    {
        [MaxLength(20)]
        public string MaNhanVien { get; set; }
        [MaxLength(150)]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        [MaxLength(6)]
        public string GioiTinh { get; set; }
        [MaxLength(12)]
        public string Cccd { get; set; }
        [MaxLength(50)]
        public string TonGiao { get; set; }
        [MaxLength(150)]
        public string DiaChi { get; set; }
        [MaxLength(11)]
        public string SoDienThoai { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public DateTime NgayVaoLam { get; set; }
        [MaxLength(150)]
        public string NguoiQuanLy { get; set; }
        public double MucLuong { get; set; }
        public byte[] AnhDaiDien { get; set; }
        [MaxLength(20)]
        public string TrangThai { get; set; }

        // Liên kết bảng Phòng ban:
        [MaxLength(20)]
        public string PhongBanId { get; set; }
        public PhongBan PhongBan { get; set; }

        // Liên kết bảng Chức vụ:
        [MaxLength(20)]
        public string ChucVuId { get; set; }
        public ChucVu ChucVu { get; set; }

        // Liên kết bảng Trình độ học vấn:
        public ICollection<TrinhDoHocVan> TrinhDoHocVans { get; set; }

        // Liên kết bảng Lương:
        public ICollection<Luong> Luongs { get; set; }

        // Liên kết bảng Phụ cấp:
        public ICollection<PhuCapNhanVien> PhuCapNhanViens { get; set; }

        // Liên kết bảng Thưởng:
        public ICollection<ThuongNhanVien> ThuongNhanViens { get; set; }

        // Liên kết bảng Thuế:
        public ICollection<Thue> Thues { get; set; }

        // Liên kết bảng Hợp đồng:
        public ICollection<HopDong> HopDongs { get; set; }

        // Liên kết bảng Hiệu suất:
        public ICollection<HieuSuat> HieuSuats { get; set; }

        // Liên kết bảng Lịch làm:
        public ICollection<LichLamNhanVien> LichLamNhanViens { get; set; }

        // Liên kết bảng Chấm công:
        public ICollection<ChamCong> ChamCongs { get; set; }

        // Liên kết bảng Nghỉ vắng:
        public ICollection<NghiVang> NghiVangs { get; set; }
    }
}
