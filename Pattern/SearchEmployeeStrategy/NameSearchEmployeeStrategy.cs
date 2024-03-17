using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagement.Pattern.SearchEmployeeStrategy
{
    public class NameSearchEmployeeStrategy : ISearchEmployeeStrategy
    {
        private readonly HumanResourceManagementDbContext _context;
        public NameSearchEmployeeStrategy(HumanResourceManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NhanVien>> SearchAsync(string keyword)
        {
            return await _context.NhanViens
                .Where(nv => nv.HoTen.Contains(keyword))
                .ToListAsync();
        }
    }
}
