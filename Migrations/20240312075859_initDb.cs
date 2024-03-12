using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourceManagement.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichLams",
                columns: table => new
                {
                    MaLichLam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioBatDau = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GioKetThuc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CaLamViec = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MoTaCongViec = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichLams", x => x.MaLichLam);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    SoPhong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenPhong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NguoiQuanLy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.SoPhong);
                });

            migrationBuilder.CreateTable(
                name: "PhuCaps",
                columns: table => new
                {
                    MaPhuCap = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenPhuCap = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SoTienPhuCap = table.Column<double>(type: "float", nullable: false),
                    TanSuat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCaps", x => x.MaPhuCap);
                });

            migrationBuilder.CreateTable(
                name: "Thuongs",
                columns: table => new
                {
                    MaKhoanThuong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayKhenThuong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienThuong = table.Column<double>(type: "float", nullable: false),
                    LyDoKhenThuong = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thuongs", x => x.MaKhoanThuong);
                });

            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MucLuong = table.Column<double>(type: "float", nullable: false),
                    MoTaCongViec = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PhongBanId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.MaChucVu);
                    table.ForeignKey(
                        name: "FK_ChucVus_PhongBans_PhongBanId",
                        column: x => x.PhongBanId,
                        principalTable: "PhongBans",
                        principalColumn: "SoPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Cccd = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TonGiao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiQuanLy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MucLuong = table.Column<double>(type: "float", nullable: false),
                    AnhDaiDien = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhongBanId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ChucVuId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVus",
                        principalColumn: "MaChucVu");
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanId",
                        column: x => x.PhongBanId,
                        principalTable: "PhongBans",
                        principalColumn: "SoPhong");
                });

            migrationBuilder.CreateTable(
                name: "ChamCongs",
                columns: table => new
                {
                    MaChamCong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayChamCong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioVaoLam = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GioRaLam = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SoGioLamViec = table.Column<double>(type: "float", nullable: false),
                    SoGioLamThem = table.Column<double>(type: "float", nullable: false),
                    SoGioNghiPhep = table.Column<double>(type: "float", nullable: false),
                    SoGioNghiKhongPhep = table.Column<double>(type: "float", nullable: false),
                    TongGioLam = table.Column<double>(type: "float", nullable: false),
                    LichLamId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCongs", x => x.MaChamCong);
                    table.ForeignKey(
                        name: "FK_ChamCongs_LichLams_LichLamId",
                        column: x => x.LichLamId,
                        principalTable: "LichLams",
                        principalColumn: "MaLichLam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChamCongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HieuSuats",
                columns: table => new
                {
                    MaHieuSuat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NguoiDanhGia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    KyDanhGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MucTieuHieuSuat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DanhGiaHieuSuat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhanHoi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    KeHoachPhatTrien = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HieuSuats", x => x.MaHieuSuat);
                    table.ForeignKey(
                        name: "FK_HieuSuats_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HopDongs",
                columns: table => new
                {
                    MaHopDong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LoaiHopDong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiHanHopDong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NoiDungHopDong = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TrangThaiHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongs", x => x.MaHopDong);
                    table.ForeignKey(
                        name: "FK_HopDongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichLamNhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LichLamId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichLamNhanViens", x => new { x.NhanVienId, x.LichLamId });
                    table.ForeignKey(
                        name: "FK_LichLamNhanViens_LichLams_LichLamId",
                        column: x => x.LichLamId,
                        principalTable: "LichLams",
                        principalColumn: "MaLichLam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichLamNhanViens_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Luongs",
                columns: table => new
                {
                    MaLuong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LuongCoBan = table.Column<double>(type: "float", nullable: false),
                    TongTienPhuCap = table.Column<double>(type: "float", nullable: false),
                    TongTienThuong = table.Column<double>(type: "float", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    CacKhoanKhauTru = table.Column<double>(type: "float", nullable: false),
                    ThuNhapRong = table.Column<double>(type: "float", nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luongs", x => x.MaLuong);
                    table.ForeignKey(
                        name: "FK_Luongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NghiVangs",
                columns: table => new
                {
                    MaNghiVang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LoaiNghiVang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoNgayNghi = table.Column<int>(type: "int", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    LichLamId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NghiVangs", x => x.MaNghiVang);
                    table.ForeignKey(
                        name: "FK_NghiVangs_LichLams_LichLamId",
                        column: x => x.LichLamId,
                        principalTable: "LichLams",
                        principalColumn: "MaLichLam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NghiVangs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhuCapNhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhuCapId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCapNhanViens", x => new { x.NhanVienId, x.PhuCapId });
                    table.ForeignKey(
                        name: "FK_PhuCapNhanViens_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhuCapNhanViens_PhuCaps_PhuCapId",
                        column: x => x.PhuCapId,
                        principalTable: "PhuCaps",
                        principalColumn: "MaPhuCap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thues",
                columns: table => new
                {
                    MaSoThue = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoNguoiPhuThuoc = table.Column<int>(type: "int", nullable: false),
                    TrangThaiHonNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MucThuNhapChiuThue = table.Column<double>(type: "float", nullable: false),
                    ThueSuat = table.Column<double>(type: "float", nullable: false),
                    ThueThuNhapCaNhanThucTe = table.Column<double>(type: "float", nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thues", x => x.MaSoThue);
                    table.ForeignKey(
                        name: "FK_Thues_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuongNhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ThuongId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongNhanViens", x => new { x.NhanVienId, x.ThuongId });
                    table.ForeignKey(
                        name: "FK_ThuongNhanViens_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuongNhanViens_Thuongs_ThuongId",
                        column: x => x.ThuongId,
                        principalTable: "Thuongs",
                        principalColumn: "MaKhoanThuong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrinhDoHocVans",
                columns: table => new
                {
                    MaTrinhDo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenTrinhDoHocVan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChuyenNganh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenTruong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameTotNghiep = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BangCap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhDoHocVans", x => x.MaTrinhDo);
                    table.ForeignKey(
                        name: "FK_TrinhDoHocVans_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_LichLamId",
                table: "ChamCongs",
                column: "LichLamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_NhanVienId",
                table: "ChamCongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVus_PhongBanId",
                table: "ChucVus",
                column: "PhongBanId");

            migrationBuilder.CreateIndex(
                name: "IX_HieuSuats_NhanVienId",
                table: "HieuSuats",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongs_NhanVienId",
                table: "HopDongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_LichLamNhanViens_LichLamId",
                table: "LichLamNhanViens",
                column: "LichLamId");

            migrationBuilder.CreateIndex(
                name: "IX_Luongs_NhanVienId",
                table: "Luongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NghiVangs_LichLamId",
                table: "NghiVangs",
                column: "LichLamId");

            migrationBuilder.CreateIndex(
                name: "IX_NghiVangs_NhanVienId",
                table: "NghiVangs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_ChucVuId",
                table: "NhanViens",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCapNhanViens_PhuCapId",
                table: "PhuCapNhanViens",
                column: "PhuCapId");

            migrationBuilder.CreateIndex(
                name: "IX_Thues_NhanVienId",
                table: "Thues",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongNhanViens_ThuongId",
                table: "ThuongNhanViens",
                column: "ThuongId");

            migrationBuilder.CreateIndex(
                name: "IX_TrinhDoHocVans_NhanVienId",
                table: "TrinhDoHocVans",
                column: "NhanVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChamCongs");

            migrationBuilder.DropTable(
                name: "HieuSuats");

            migrationBuilder.DropTable(
                name: "HopDongs");

            migrationBuilder.DropTable(
                name: "LichLamNhanViens");

            migrationBuilder.DropTable(
                name: "Luongs");

            migrationBuilder.DropTable(
                name: "NghiVangs");

            migrationBuilder.DropTable(
                name: "PhuCapNhanViens");

            migrationBuilder.DropTable(
                name: "Thues");

            migrationBuilder.DropTable(
                name: "ThuongNhanViens");

            migrationBuilder.DropTable(
                name: "TrinhDoHocVans");

            migrationBuilder.DropTable(
                name: "LichLams");

            migrationBuilder.DropTable(
                name: "PhuCaps");

            migrationBuilder.DropTable(
                name: "Thuongs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "ChucVus");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
