using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DuAnOne.DAL.Entities
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = null!;
        public virtual DbSet<ChuThe> ChuThes { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<TheThuVien> TheThuViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=POWWA;Database=DuAn12Nhom8;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
            {
                entity.HasKey(e => new { e.IdPhieuMuon, e.IdSach })
                    .HasName("PK__ChiTietP__311855532766B746");

                entity.ToTable("ChiTietPhieuMuon");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdPhieuMuonNavigation)
                    .WithMany(p => p.ChiTietPhieuMuons)
                    .HasForeignKey(d => d.IdPhieuMuon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietPh__IdPhi__4F7CD00D");

                entity.HasOne(d => d.IdSachNavigation)
                    .WithMany(p => p.ChiTietPhieuMuons)
                    .HasForeignKey(d => d.IdSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietPh__IdSac__5070F446");
            });

            modelBuilder.Entity<ChuThe>(entity =>
            {
                entity.ToTable("ChuThe");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoVaTen).HasMaxLength(100);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.NgheNghiep).HasMaxLength(100);

                entity.Property(e => e.NoiLamViec).HasMaxLength(200);

                entity.Property(e => e.QuocTich).HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoVaTen).HasMaxLength(100);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<PhieuMuon>(entity =>
            {
                entity.ToTable("PhieuMuon");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.NgayMuon).HasColumnType("datetime");

                entity.Property(e => e.NgayTra).HasColumnType("datetime");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.PhieuMuons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuMuon__IdNha__4BAC3F29");

                entity.HasOne(d => d.IdTheNavigation)
                    .WithMany(p => p.PhieuMuons)
                    .HasForeignKey(d => d.IdThe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuMuon__IdThe__4CA06362");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.TacGia).HasMaxLength(100);

                entity.Property(e => e.TenSach).HasMaxLength(100);

                entity.Property(e => e.TheLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdNhanVien)
                    .HasName("PK__TaiKhoan__B8294845C61EA9F1");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.IdNhanVien).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.TenTaiKhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithOne(p => p.TaiKhoan)
                    .HasForeignKey<TaiKhoan>(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TaiKhoan__IdNhan__534D60F1");
            });

            modelBuilder.Entity<TheThuVien>(entity =>
            {
                entity.ToTable("TheThuVien");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MaThe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.NgayCap).HasColumnType("datetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.HasOne(d => d.IdChuTheNavigation)
                    .WithMany(p => p.TheThuViens)
                    .HasForeignKey(d => d.IdChuThe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheThuVie__IdChu__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
