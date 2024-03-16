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
        public async Task<IActionResult> ThemPhongBan(PhongBanDTO phongBanDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var phongBan = new PhongBan
            {
                SoPhong = phongBanDto.SoPhong,
                TenPhong = phongBanDto.TenPhong,
                NguoiQuanLy = phongBanDto.NguoiQuanLy,
                Email = phongBanDto.Email,
                DiaDiem = phongBanDto.DiaDiem,
                MoTa = phongBanDto.MoTa
            };

            await _dbContext.PhongBans.AddAsync(phongBan);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatPhongBan(string id, PhongBanDTO phongBanDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingPhongBan = await _dbContext.PhongBans.FirstOrDefaultAsync(pb => pb.SoPhong == id);
            if (existingPhongBan == null)
            {
                return NotFound();
            }

            existingPhongBan.SoPhong = phongBanDto.SoPhong;
            existingPhongBan.TenPhong = phongBanDto.TenPhong;
            existingPhongBan.NguoiQuanLy = phongBanDto.NguoiQuanLy;
            existingPhongBan.Email = phongBanDto.Email;
            existingPhongBan.DiaDiem = phongBanDto.DiaDiem;
            existingPhongBan.MoTa = phongBanDto.MoTa;

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