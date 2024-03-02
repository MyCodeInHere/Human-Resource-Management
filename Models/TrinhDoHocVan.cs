using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.Models
{
    public class TrinhDoHocVan
    {
        [MaxLength(20)]
        public string MaTrinhDo { get; set; }
        [MaxLength(100)]
        public string TenTrinhDoHocVan { get; set; }
        [MaxLength(50)]
        public string ChuyenNganh {  get; set; }
        [MaxLength(100)]
        public string TenTruong { get; set; }
        public DateTime NameTotNghiep { get; set; }
        [MaxLength(50)]
        public string BangCap {  get; set; }

        // Liên kết bảng Nhân viên:
        [MaxLength(20)]
        public string NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
