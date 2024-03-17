using HumanResourceManagement.Models;

namespace HumanResourceManagement.Pattern.SearchEmployeeStrategy
{
    public interface ISearchEmployeeStrategy
    {
        Task<List<NhanVien>> SearchAsync(string keyword);
    }
}
