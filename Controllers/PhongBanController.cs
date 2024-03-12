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

        [HttpGet("{id}")]
        public async Task<ActionResult<PhongBan>> GetPhongBan(string id)
        {
            var phongBan = await _dbContext.PhongBans.FindAsync(id);

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

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatPhongBan(string id, PhongBan phongBan)
        {
            var existingPhongBan = await _dbContext.PhongBans.FirstOrDefaultAsync(pb => pb.SoPhong == id);
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> XoaPhongBan(string id)
        {
            var phongBan = await _dbContext.PhongBans.FirstOrDefaultAsync(pb => pb.SoPhong == id);
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