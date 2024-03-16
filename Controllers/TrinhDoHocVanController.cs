using HumanResourceManagement.DTOs;
using HumanResourceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrinhDoHocVanController : ControllerBase
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public TrinhDoHocVanController(HumanResourceManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrinhDoHocVan()
        {
            var trinhDoHocVans = await _dbContext.TrinhDoHocVans.ToListAsync();
            return Ok(trinhDoHocVans);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrinhDoHocVan>> GetTrinhDoHocVan(string id)
        {
            var trinhDoHocVan = await _dbContext.TrinhDoHocVans.FindAsync(id);

            if (trinhDoHocVan == null)
            {
                return NotFound();
            }

            return trinhDoHocVan;
        }

        [HttpPost]
        public async Task<IActionResult> ThemTrinhDoHocVan(TrinhDoHocVanDTO trinhDoHocVanDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var trinhDoHocVan = new TrinhDoHocVan
            {
                MaTrinhDo = trinhDoHocVanDTO.MaTrinhDo,
                TenTrinhDoHocVan = trinhDoHocVanDTO.TenTrinhDoHocVan,
                ChuyenNganh = trinhDoHocVanDTO.ChuyenNganh,
                TenTruong = trinhDoHocVanDTO.TenTruong,
                NameTotNghiep = trinhDoHocVanDTO.NameTotNghiep,
                BangCap = trinhDoHocVanDTO.BangCap,
            };

            if (!string.IsNullOrEmpty(trinhDoHocVanDTO.NhanVienId))
            {
                trinhDoHocVan.NhanVienId = trinhDoHocVanDTO.NhanVienId;
            }

            await _dbContext.TrinhDoHocVans.AddAsync(trinhDoHocVan);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatTrinhDoHocVan(string id, TrinhDoHocVanDTO trinhDoHocVanDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingTrinhDoHocVan = await _dbContext.TrinhDoHocVans.FirstOrDefaultAsync(tdhv => tdhv.MaTrinhDo == id);
            if (existingTrinhDoHocVan == null)
            {
                return NotFound();
            }

            existingTrinhDoHocVan.MaTrinhDo = trinhDoHocVanDTO.MaTrinhDo;
            existingTrinhDoHocVan.TenTrinhDoHocVan = trinhDoHocVanDTO.TenTrinhDoHocVan;
            existingTrinhDoHocVan.ChuyenNganh = trinhDoHocVanDTO.ChuyenNganh;
            existingTrinhDoHocVan.TenTruong = trinhDoHocVanDTO.TenTruong;
            existingTrinhDoHocVan.NameTotNghiep = trinhDoHocVanDTO.NameTotNghiep;
            existingTrinhDoHocVan.BangCap = trinhDoHocVanDTO.BangCap;

            if (!string.IsNullOrEmpty(trinhDoHocVanDTO.NhanVienId))
            {
                existingTrinhDoHocVan.NhanVienId = trinhDoHocVanDTO.NhanVienId;
            }
            else
            {
                existingTrinhDoHocVan.NhanVienId = null;
            }

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> XoaTrinhDoHocVan(string id)
        {
            var trinhDoHocVan = await _dbContext.TrinhDoHocVans.FirstOrDefaultAsync(tdhv => tdhv.MaTrinhDo == id);
            if (trinhDoHocVan == null)
            {
                return NotFound();
            }

            _dbContext.TrinhDoHocVans.Remove(trinhDoHocVan);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
