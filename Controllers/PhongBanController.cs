using HumanResourceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhongBanController : ControllerBase
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public PhongBanController(HumanResourceManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPhongBans()
        {
            var phongBans = await _dbContext.PhongBans.ToListAsync();
            return Ok(phongBans);
        }

        [HttpGet("{MaPhongBan}")]
        public async Task<ActionResult<PhongBan>> GetPhongBan(string maPhongBan)
        {
            var phongBan = await _dbContext.PhongBans.FindAsync(maPhongBan);

            if (phongBan == null)
            {
                return NotFound();
            }

            return phongBan;
        }

        [HttpPost]
        public async Task<IActionResult> ThemPhongBan(PhongBan phongBan)
        {
            await _dbContext.PhongBans.AddAsync(phongBan);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{soPhong}")]
        public async Task<IActionResult> CapNhatPhongBan(string soPhong, PhongBan phongBan)
        {
            var existingPhongBan = await _dbContext.PhongBans.FirstOrDefaultAsync(pb => pb.SoPhong == soPhong);
            if (existingPhongBan == null)
            {
                return NotFound();
            }

            existingPhongBan.TenPhong = phongBan.TenPhong;
            existingPhongBan.NguoiQuanLy = phongBan.NguoiQuanLy;
            existingPhongBan.Email = phongBan.Email;
            existingPhongBan.DiaDiem = phongBan.DiaDiem;
            existingPhongBan.MoTa = phongBan.MoTa;

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{soPhong}")]
        public async Task<IActionResult> XoaPhongBan(string soPhong)
        {
            var phongBan = await _dbContext.PhongBans.FirstOrDefaultAsync(pb => pb.SoPhong == soPhong);
            if (phongBan == null)
            {
                return NotFound();
            }

            _dbContext.PhongBans.Remove(phongBan);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}