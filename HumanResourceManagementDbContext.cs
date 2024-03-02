using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagement
{
    public class HumanResourceManagementDbContext : DbContext
    {
        public HumanResourceManagementDbContext(DbContextOptions<HumanResourceManagementDbContext> options) : base(options) { }

        public DbSet<LichLamNhanVien> LichLamNhanViens { get; set; }
        public DbSet<NghiVang> NghiVangs { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<LichLam> LichLams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<TrinhDoHocVan> TrinhDoHocVans { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<PhuCapNhanVien> PhuCapNhanViens { get; set; }
        public DbSet<PhuCap> PhuCaps { get; set; }
        public DbSet<ThuongNhanVien> ThuongNhanViens { get; set; }
        public DbSet<Thuong> Thuongs { get; set; }
        public DbSet<Thue> Thues { get; set; }
        public DbSet<HieuSuat> HieuSuats { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LichLamNhanVien>()
                .HasKey(llnv => new { llnv.NhanVienId, llnv.LichLamId });

            modelBuilder.Entity<NghiVang>()
                .HasKey(nv => nv.MaNghiVang);

            modelBuilder.Entity<ChamCong>()
                .HasKey(cc => cc.MaChamCong);

            modelBuilder.Entity<LichLam>()
                .HasKey(ll => ll.MaLichLam);

            modelBuilder.Entity<NhanVien>()
                .HasKey(nv => nv.MaNhanVien);

            modelBuilder.Entity<ChucVu>()
                .HasKey(cv => cv.MaChucVu);

            modelBuilder.Entity<PhongBan>()
                .HasKey(pb => pb.SoPhong);

            modelBuilder.Entity<TrinhDoHocVan>()
                .HasKey(tdhv => tdhv.MaTrinhDo);

            modelBuilder.Entity<Luong>()
                .HasKey(l => l.MaLuong);

            modelBuilder.Entity<PhuCapNhanVien>()
                .HasKey(pcnv => new { pcnv.NhanVienId, pcnv.PhuCapId });

            modelBuilder.Entity<PhuCap>()
               .HasKey(pc => pc.MaPhuCap);

            modelBuilder.Entity<ThuongNhanVien>()
                .HasKey(tnv => new { tnv.NhanVienId, tnv.ThuongId });

            modelBuilder.Entity<Thuong>()
               .HasKey(t => t.MaKhoanThuong);

            modelBuilder.Entity<Thue>()
               .HasKey(t => t.MaSoThue);

            modelBuilder.Entity<HieuSuat>()
               .HasKey(hs => hs.MaHieuSuat);

            modelBuilder.Entity<HopDong>()
               .HasKey(hd => hd.MaHopDong);

            // Liên kết bảng LichLamNhanVien với NhanVien
            modelBuilder.Entity<LichLamNhanVien>()
                .HasOne(llnv => llnv.NhanVien)
                .WithMany(nv => nv.LichLamNhanViens)
                .HasForeignKey(llnv => llnv.NhanVienId);

            // Liên kết bảng LichLamNhanVien với LichLam
            modelBuilder.Entity<LichLamNhanVien>()
                .HasOne(llnv => llnv.LichLam)
                .WithMany(ll => ll.LichLamNhanViens)
                .HasForeignKey(llnv => llnv.LichLamId);

            // Liên kết bảng NghiVang với LichLam
            modelBuilder.Entity<NghiVang>()
                .HasOne(nv => nv.LichLam)
                .WithMany(ll => ll.NghiVangs)
                .HasForeignKey(nv => nv.LichLamId);

            // Liên kết bảng NghiVang với NhanVien
            modelBuilder.Entity<NghiVang>()
                .HasOne(nv => nv.NhanVien)
                .WithMany(nv => nv.NghiVangs)
                .HasForeignKey(nv => nv.NhanVienId);

            // Liên kết bảng ChamCong với LichLam
            modelBuilder.Entity<ChamCong>()
                .HasOne(cc => cc.LichLam)
                .WithMany(ll => ll.ChamCongs)
                .HasForeignKey(cc => cc.LichLamId);

            // Liên kết bảng ChamCong với NhanVien
            modelBuilder.Entity<ChamCong>()
                .HasOne(cc => cc.NhanVien)
                .WithMany(nv => nv.ChamCongs)
                .HasForeignKey(cc => cc.NhanVienId);

            // Liên kết bảng ChucVu với NhanVien
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.ChucVu)
                .WithMany(cv => cv.NhanViens)
                .HasForeignKey(nv => nv.ChucVuId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            // Liên kết bảng PhongBan với NhanVien
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.PhongBan)
                .WithMany(pb => pb.NhanViens)
                .HasForeignKey(nv => nv.PhongBanId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            // Liên kết bảng PhongBan với ChucVu
            modelBuilder.Entity<PhongBan>()
                .HasMany(pb => pb.ChucVus)
                .WithOne(cv => cv.PhongBan)
                .HasForeignKey(cv => cv.PhongBanId);

            // Liên kết bảng TrinhDoHocVan với NhanVien
            modelBuilder.Entity<TrinhDoHocVan>()
                .HasOne(nv => nv.NhanVien)
                .WithMany(tdhv => tdhv.TrinhDoHocVans)
                .HasForeignKey(nv => nv.NhanVienId);

            // Liên kết bảng Luong với NhanVien
            modelBuilder.Entity<Luong>()
                .HasOne(nv => nv.NhanVien)
                .WithMany(l => l.Luongs)
                .HasForeignKey(nv => nv.NhanVienId);

            // Liên kết bảng PhuCapNhanVien với NhanVien
            modelBuilder.Entity<PhuCapNhanVien>()
                .HasOne(pcnv => pcnv.NhanVien)
                .WithMany(nv => nv.PhuCapNhanViens)
                .HasForeignKey(llnv => llnv.NhanVienId);

            // Liên kết bảng PhuCapNhanVien với PhuCap
            modelBuilder.Entity<PhuCapNhanVien>()
                .HasOne(pcnv => pcnv.PhuCap)
                .WithMany(pc => pc.PhuCapNhanViens)
                .HasForeignKey(pcnv => pcnv.PhuCapId);

            // Liên kết bảng ThuongNhanVien với NhanVien
            modelBuilder.Entity<ThuongNhanVien>()
                .HasOne(tnv => tnv.NhanVien)
                .WithMany(nv => nv.ThuongNhanViens)
                .HasForeignKey(tnv => tnv.NhanVienId);

            // Liên kết bảng ThuongNhanVien với Thuong
            modelBuilder.Entity<ThuongNhanVien>()
                .HasOne(tnv => tnv.Thuong)
                .WithMany(pc => pc.ThuongNhanViens)
                .HasForeignKey(tnv => tnv.ThuongId);

            // Liên kết bảng Thue với NhanVien
            modelBuilder.Entity<Thue>()
                .HasOne(t => t.NhanVien)
                .WithMany(nv => nv.Thues)
                .HasForeignKey(t => t.NhanVienId);

            // Liên kết bảng HieuSuat với NhanVien
            modelBuilder.Entity<HieuSuat>()
                .HasOne(hs => hs.NhanVien)
                .WithMany(nv => nv.HieuSuats)
                .HasForeignKey(hs => hs.NhanVienId);

            // Liên kết bảng HopDong với NhanVien
            modelBuilder.Entity<HopDong>()
                .HasOne(hd => hd.NhanVien)
                .WithMany(nv => nv.HopDongs)
                .HasForeignKey(hd => hd.NhanVienId);
        }
    }
}