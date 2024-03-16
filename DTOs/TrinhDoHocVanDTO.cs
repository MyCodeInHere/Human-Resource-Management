using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class TrinhDoHocVanDTO
    {
        [Required(ErrorMessage = "Mã trình độ học vấn không được để trống!")]
        [MaxLength(20)]
        public string MaTrinhDo { get; set; }
        [Required(ErrorMessage = "Tên trình độ học vấn không được để trống!")]
        [MaxLength(100)]
        public string TenTrinhDoHocVan { get; set; }
        [Required(ErrorMessage = "Chuyên ngành không được để trống!")]
        [MaxLength(50)]
        public string ChuyenNganh { get; set; }
        [Required(ErrorMessage = "Tên trường không được để trống!")]
        [MaxLength(100)]
        public string TenTruong { get; set; }
        [Required(ErrorMessage = "Năm tốt nghiệp không được để trống!")]
        public DateTime NameTotNghiep { get; set; }
        [Required(ErrorMessage = "Bằng cấp không được để trống!")]
        [MaxLength(50)]
        public string BangCap { get; set; }
        public string NhanVienId { get; set; }
    }
}
