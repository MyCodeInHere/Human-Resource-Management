using HumanResourceManagement.Models;

namespace HumanResourceManagement.Pattern.SearchEmployeeStrategy
{
    public class IdSearchEmployeeStrategy : ISearchEmployeeStrategy
    {
        private readonly HumanResourceManagementDbContext _context;
        public IdSearchEmployeeStrategy(HumanResourceManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NhanVien>> SearchAsync(string id)
        {
            var nhanVien = await _context.NhanViens.FindAsync(id);
            return nhanVien != null ? new List<NhanVien> { nhanVien } : new List<NhanVien>();
        }
    }
}
