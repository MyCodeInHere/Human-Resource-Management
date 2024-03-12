using HumanResourceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChucVuController : ControllerBase
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public ChucVuController(HumanResourceManagementDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetChucVus()
        {
            var chucVus = await _dbContext.ChucVus.ToListAsync();
            return Ok(chucVus);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChucVu>> GetChucVu(string id)
        {
            var chucVu = await _dbContext.ChucVus.FindAsync(id);

            if (chucVu == null)
            {
                return NotFound();
            }

            return chucVu;
        }

        [HttpPost]
        public async Task<IActionResult> ThemChucVu(ChucVu chucVu)
        {
            _dbContext.ChucVus.Add(chucVu);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatChucVu(string id, ChucVu chucVu)
        {
            var existingChucVu = await _dbContext.ChucVus.FirstOrDefaultAsync(cv => cv.MaChucVu == id);

            if (existingChucVu == null)
            {
                return NotFound();
            }

            existingChucVu.TenChucVu = chucVu.TenChucVu;
            existingChucVu.MoTaCongViec = chucVu.MoTaCongViec;
            existingChucVu.MucLuong = chucVu.MucLuong;
            existingChucVu.PhongBan = chucVu.PhongBan;

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> XoaChucVu(string id)
        {
            var existingChucVu = await _dbContext.ChucVus.FirstOrDefaultAsync(cv => cv.MaChucVu == id);

            if (existingChucVu == null)
            {
                return NotFound();
            }

            _dbContext.ChucVus.Remove(existingChucVu);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}