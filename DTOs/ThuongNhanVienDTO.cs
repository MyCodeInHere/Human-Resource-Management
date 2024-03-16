using HumanResourceManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class ThuongNhanVienDTO
    {
        [MaxLength(20)]
        public string NhanVienId { get; set; }

        [MaxLength(20)]
        public string ThuongId { get; set; }
    }
}
