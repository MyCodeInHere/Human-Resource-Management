﻿// <auto-generated />
using System;
using HumanResourceManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HumanResourceManagement.Migrations
{
    [DbContext(typeof(HumanResourceManagementDbContext))]
    [Migration("20240302035225_Inital")]
    partial class Inital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HumanResourceManagement.Models.ChamCong", b =>
                {
                    b.Property<string>("MaChamCong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GioRaLam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioVaoLam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LichLamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayChamCong")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("SoGioLamThem")
                        .HasColumnType("float");

                    b.Property<double>("SoGioLamViec")
                        .HasColumnType("float");

                    b.Property<double>("SoGioNghiKhongPhep")
                        .HasColumnType("float");

                    b.Property<double>("SoGioNghiPhep")
                        .HasColumnType("float");

                    b.Property<double>("TongGioLam")
                        .HasColumnType("float");

                    b.HasKey("MaChamCong");

                    b.HasIndex("LichLamId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("ChamCongs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTaCongViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MucLuong")
                        .HasColumnType("float");

                    b.Property<string>("PhongBanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChucVu");

                    b.HasIndex("PhongBanId");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.HieuSuat", b =>
                {
                    b.Property<string>("MaHieuSuat")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanhGiaHieuSuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeHoachPhatTrien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KyDanhGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MucTieuHieuSuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiDanhGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhanHoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHieuSuat");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HieuSuats");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.HopDong", b =>
                {
                    b.Property<string>("MaHopDong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiHopDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKy")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NoiDungHopDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiHanHopDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThaiHopDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHopDong");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HopDongs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.LichLam", b =>
                {
                    b.Property<string>("MaLichLam")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CaLamViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioBatDau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioKetThuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTaCongViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayLam")
                        .HasColumnType("datetime2");

                    b.HasKey("MaLichLam");

                    b.ToTable("LichLams");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.LichLamNhanVien", b =>
                {
                    b.Property<string>("NhanVienId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LichLamId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NhanVienId", "LichLamId");

                    b.HasIndex("LichLamId");

                    b.ToTable("LichLamNhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Luong", b =>
                {
                    b.Property<string>("MaLuong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("CacKhoanKhauTru")
                        .HasColumnType("float");

                    b.Property<double>("LuongCoBan")
                        .HasColumnType("float");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ThuNhapRong")
                        .HasColumnType("float");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.Property<double>("TongTienPhuCap")
                        .HasColumnType("float");

                    b.Property<double>("TongTienThuong")
                        .HasColumnType("float");

                    b.HasKey("MaLuong");

                    b.HasIndex("NhanVienId");

                    b.ToTable("Luongs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.NghiVang", b =>
                {
                    b.Property<string>("MaNghiVang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LichLamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoaiNghiVang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LyDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoNgayNghi")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNghiVang");

                    b.HasIndex("LichLamId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("NghiVangs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("AnhDaiDien")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Cccd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChucVuId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MucLuong")
                        .HasColumnType("float");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVaoLam")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiQuanLy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongBanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TonGiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.HasIndex("ChucVuId");

                    b.HasIndex("PhongBanId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhongBan", b =>
                {
                    b.Property<string>("SoPhong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaDiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiQuanLy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoPhong");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhuCap", b =>
                {
                    b.Property<string>("MaPhuCap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("SoTienPhuCap")
                        .HasColumnType("float");

                    b.Property<string>("TanSuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhuCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhuCap");

                    b.ToTable("PhuCaps");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhuCapNhanVien", b =>
                {
                    b.Property<string>("NhanVienId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhuCapId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NhanVienId", "PhuCapId");

                    b.HasIndex("PhuCapId");

                    b.ToTable("PhuCapNhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Thue", b =>
                {
                    b.Property<string>("MaSoThue")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("MucThuNhapChiuThue")
                        .HasColumnType("float");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoNguoiPhuThuoc")
                        .HasColumnType("int");

                    b.Property<double>("ThueSuat")
                        .HasColumnType("float");

                    b.Property<double>("ThueThuNhapCaNhanThucTe")
                        .HasColumnType("float");

                    b.Property<string>("TrangThaiHonNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSoThue");

                    b.HasIndex("NhanVienId");

                    b.ToTable("Thues");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Thuong", b =>
                {
                    b.Property<string>("MaKhoanThuong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LyDoKhenThuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayKhenThuong")
                        .HasColumnType("datetime2");

                    b.Property<double>("SoTienThuong")
                        .HasColumnType("float");

                    b.HasKey("MaKhoanThuong");

                    b.ToTable("Thuongs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ThuongNhanVien", b =>
                {
                    b.Property<string>("NhanVienId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ThuongId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NhanVienId", "ThuongId");

                    b.HasIndex("ThuongId");

                    b.ToTable("ThuongNhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.TrinhDoHocVan", b =>
                {
                    b.Property<string>("MaTrinhDo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BangCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChuyenNganh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NameTotNghiep")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTrinhDoHocVan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTruong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTrinhDo");

                    b.HasIndex("NhanVienId");

                    b.ToTable("TrinhDoHocVans");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ChamCong", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.LichLam", "LichLam")
                        .WithMany("ChamCongs")
                        .HasForeignKey("LichLamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("ChamCongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LichLam");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ChucVu", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.PhongBan", "PhongBan")
                        .WithMany("ChucVus")
                        .HasForeignKey("PhongBanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.HieuSuat", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("HieuSuats")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.HopDong", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("HopDongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.LichLamNhanVien", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.LichLam", "LichLam")
                        .WithMany("LichLamNhanViens")
                        .HasForeignKey("LichLamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("LichLamNhanViens")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LichLam");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Luong", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("Luongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.NghiVang", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.LichLam", "LichLam")
                        .WithMany("NghiVangs")
                        .HasForeignKey("LichLamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("NghiVangs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LichLam");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.NhanVien", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("ChucVuId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.PhongBan", "PhongBan")
                        .WithMany("NhanViens")
                        .HasForeignKey("PhongBanId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("ChucVu");

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhuCapNhanVien", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("PhuCapNhanViens")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.PhuCap", "PhuCap")
                        .WithMany("PhuCapNhanViens")
                        .HasForeignKey("PhuCapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");

                    b.Navigation("PhuCap");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Thue", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("Thues")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ThuongNhanVien", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("ThuongNhanViens")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagement.Models.Thuong", "Thuong")
                        .WithMany("ThuongNhanViens")
                        .HasForeignKey("ThuongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");

                    b.Navigation("Thuong");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.TrinhDoHocVan", b =>
                {
                    b.HasOne("HumanResourceManagement.Models.NhanVien", "NhanVien")
                        .WithMany("TrinhDoHocVans")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.LichLam", b =>
                {
                    b.Navigation("ChamCongs");

                    b.Navigation("LichLamNhanViens");

                    b.Navigation("NghiVangs");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.NhanVien", b =>
                {
                    b.Navigation("ChamCongs");

                    b.Navigation("HieuSuats");

                    b.Navigation("HopDongs");

                    b.Navigation("LichLamNhanViens");

                    b.Navigation("Luongs");

                    b.Navigation("NghiVangs");

                    b.Navigation("PhuCapNhanViens");

                    b.Navigation("Thues");

                    b.Navigation("ThuongNhanViens");

                    b.Navigation("TrinhDoHocVans");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhongBan", b =>
                {
                    b.Navigation("ChucVus");

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.PhuCap", b =>
                {
                    b.Navigation("PhuCapNhanViens");
                });

            modelBuilder.Entity("HumanResourceManagement.Models.Thuong", b =>
                {
                    b.Navigation("ThuongNhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
