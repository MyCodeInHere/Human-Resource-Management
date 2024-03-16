using HumanResourceManagement.Models;
using HumanResourceManagement.DTOs;
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

        public ChucVuController(HumanResourceManagementDbContext dbContext)
        {
            _dbContext = dbContext;
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
        public async Task<IActionResult> ThemChucVu(ChucVuDTO chucVuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var chucVu = new ChucVu
            {
                MaChucVu = chucVuDto.MaChucVu,
                TenChucVu = chucVuDto.TenChucVu,
                MucLuong = chucVuDto.MucLuong,
                MoTaCongViec = chucVuDto.MoTaCongViec
            };

            if (!string.IsNullOrEmpty(chucVuDto.PhongBanId))
            {
                chucVu.PhongBanId = chucVuDto.PhongBanId;
            }

            await _dbContext.ChucVus.AddAsync(chucVu);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatChucVu(string id, ChucVuDTO chucVuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingChucVu = await _dbContext.ChucVus.FirstOrDefaultAsync(cv => cv.MaChucVu == id);
            if (existingChucVu == null)
            {
                return NotFound();
            }

            existingChucVu.MaChucVu = chucVuDto.MaChucVu;
            existingChucVu.TenChucVu = chucVuDto.TenChucVu;
            existingChucVu.MucLuong = chucVuDto.MucLuong;
            existingChucVu.MoTaCongViec = chucVuDto.MoTaCongViec;
            existingChucVu.PhongBanId = chucVuDto.PhongBanId;

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> XoaChucVu(string id)
        {
            var chucVu = await _dbContext.ChucVus.FirstOrDefaultAsync(cv => cv.MaChucVu == id);
            if (chucVu == null)
            {
                return NotFound();
            }

            _dbContext.ChucVus.Remove(chucVu);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}