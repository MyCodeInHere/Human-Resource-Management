using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagement.Pattern.SearchEmployeeStrategy
{
    public class PhoneSearchEmployeeStrategy : ISearchEmployeeStrategy
    {
        private readonly HumanResourceManagementDbContext _context;
        public PhoneSearchEmployeeStrategy(HumanResourceManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NhanVien>> SearchAsync(string phoneNumber)
        {
            var nhanVien = await _context.NhanViens
                .FirstOrDefaultAsync(nv => nv.SoDienThoai == phoneNumber);
            return nhanVien != null ? new List<NhanVien> { nhanVien } : new List<NhanVien>();
        }
    }
}
