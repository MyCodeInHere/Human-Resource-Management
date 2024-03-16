using HumanResourceManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace HumanResourceManagement.DTOs
{
    public class LichLamNhanVienDTO
    {

        [MaxLength(20)]
        public string NhanVienId { get; set; }

        [MaxLength(20)]
        public string LichLamId { get; set; }
    }
}
