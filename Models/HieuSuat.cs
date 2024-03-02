using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class HieuSuat
    {
        [MaxLength(20)]
        public string MaHieuSuat {  get; set; }
        [MaxLength(150)]
        public string NguoiDanhGia { get; set; }
        [MaxLength(50)]
        public string KyDanhGia { get; set; }
        [MaxLength(200)]
        public string MucTieuHieuSuat { get; set; }
        [MaxLength(200)]
        public string DanhGiaHieuSuat { get; set; }
        [MaxLength(200)]
        public string PhanHoi {  get; set; }
        [MaxLength(500)]
        public string KeHoachPhatTrien { get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien {  get; set; }
    }
}
