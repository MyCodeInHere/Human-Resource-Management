using HumanResourceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NhanVienController : ControllerBase
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public NhanVienController(HumanResourceManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhanVien>>> GetNhanViens()
        {
            return await _dbContext.NhanViens.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NhanVien>> GetNhanVien(string id)
        {
            var nhanVien = await _dbContext.NhanViens.FindAsync(id);

            if (nhanVien == null)
            {
                return NotFound();
            }

            return nhanVien;
        }

        [HttpPost]
        public async Task<ActionResult<NhanVien>> CreateNhanVien(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Add(nhanVien);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNhanVien), new { id = nhanVien.MaNhanVien }, nhanVien);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<NhanVien>> UpdateNhanVien(string id, NhanVien nhanVien)
        {
            if (id != nhanVien.MaNhanVien)
            {
                return BadRequest();
            }

            var existingNhanVien = await _dbContext.NhanViens.FindAsync(id);

            if (existingNhanVien == null)
            {
                return NotFound();
            }

            _dbContext.Entry(existingNhanVien).CurrentValues.SetValues(nhanVien);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhanVienExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(nhanVien);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhanVien(string id)
        {
            var nhanVien = await _dbContext.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            _dbContext.NhanViens.Remove(nhanVien);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        private bool NhanVienExists(string id)
        {
            return _dbContext.NhanViens.Any(nv => nv.MaNhanVien == id);
        }
    }
}