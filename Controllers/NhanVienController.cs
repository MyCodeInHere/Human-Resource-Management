using HumanResourceManagement.Models;
using HumanResourceManagement.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetNhanViens()
        {
            var nhanViens = await _dbContext.NhanViens.ToListAsync();
            return Ok(nhanViens);
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
        public async Task<IActionResult> ThemNhanVien(NhanVienDTO nhanVienDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var nhanVien = new NhanVien
            {
                MaNhanVien = nhanVienDto.MaNhanVien,
                HoTen = nhanVienDto.HoTen,
                NgaySinh = nhanVienDto.NgaySinh,
                GioiTinh = nhanVienDto.GioiTinh,
                Cccd = nhanVienDto.Cccd,
                TonGiao = nhanVienDto.TonGiao,
                DiaChi = nhanVienDto.DiaChi,
                SoDienThoai = nhanVienDto.SoDienThoai,
                Email = nhanVienDto.Email,
                NgayVaoLam = nhanVienDto.NgayVaoLam,
                NguoiQuanLy = nhanVienDto.NguoiQuanLy,
                MucLuong = nhanVienDto.MucLuong,
                AnhDaiDien = nhanVienDto.AnhDaiDien,
                TrangThai = nhanVienDto.TrangThai
            };

            if (!string.IsNullOrEmpty(nhanVienDto.PhongBanId))
            {
                nhanVien.PhongBanId = nhanVienDto.PhongBanId;
            }

            if (!string.IsNullOrEmpty(nhanVienDto.ChucVuId))
            {
                nhanVien.ChucVuId = nhanVienDto.ChucVuId;
            }

            await _dbContext.NhanViens.AddAsync(nhanVien);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatNhanVien(string id, NhanVienDTO nhanVienDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingNhanVien = await _dbContext.NhanViens.FirstOrDefaultAsync(nv => nv.MaNhanVien == id);

            if (existingNhanVien == null)
            {
                return NotFound();
            }

            existingNhanVien.MaNhanVien = nhanVienDto.MaNhanVien;
            existingNhanVien.HoTen = nhanVienDto.HoTen;
            existingNhanVien.NgaySinh = nhanVienDto.NgaySinh;
            existingNhanVien.GioiTinh = nhanVienDto.GioiTinh;
            existingNhanVien.Cccd = nhanVienDto.Cccd;
            existingNhanVien.TonGiao = nhanVienDto.TonGiao;
            existingNhanVien.DiaChi = nhanVienDto.DiaChi;
            existingNhanVien.SoDienThoai = nhanVienDto.SoDienThoai;
            existingNhanVien.Email = nhanVienDto.Email;
            existingNhanVien.NgayVaoLam = nhanVienDto.NgayVaoLam;
            existingNhanVien.NguoiQuanLy = nhanVienDto.NguoiQuanLy;
            existingNhanVien.MucLuong = nhanVienDto.MucLuong;
            existingNhanVien.AnhDaiDien = nhanVienDto.AnhDaiDien;
            existingNhanVien.TrangThai = nhanVienDto.TrangThai;

            if (!string.IsNullOrEmpty(nhanVienDto.PhongBanId))
            {
                existingNhanVien.PhongBanId = nhanVienDto.PhongBanId;
            }
            else
            {
                existingNhanVien.PhongBanId = null;
            }

            if (!string.IsNullOrEmpty(nhanVienDto.ChucVuId))
            {
                existingNhanVien.ChucVuId = nhanVienDto.ChucVuId;
            }
            else
            {
                existingNhanVien.ChucVuId = null;
            }

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> XoaNhanVien(string id)
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
    }
}