using DuAnOne.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DuAnOne.DAL
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
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<TheThuVien> TheThuViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=POWWA;Database=DuAn1;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
            {
                entity.HasKey(e => new { e.IdPhieuMuon, e.IdSach })
                    .HasName("PK__ChiTietP__311855534E0844DC");

                entity.ToTable("ChiTietPhieuMuon");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdPhieuMuonNavigation)
                    .WithMany(p => p.ChiTietPhieuMuons)
                    .HasForeignKey(d => d.IdPhieuMuon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietPh__IdPhi__4CA06362");

                entity.HasOne(d => d.IdSachNavigation)
                    .WithMany(p => p.ChiTietPhieuMuons)
                    .HasForeignKey(d => d.IdSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietPh__IdSac__4D94879B");
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

                entity.Property(e => e.NgayTraThucTe).HasColumnType("datetime");

                entity.HasOne(d => d.IdTaiKhoanNavigation)
                    .WithMany(p => p.PhieuMuons)
                    .HasForeignKey(d => d.IdTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuMuon__IdTai__48CFD27E");

                entity.HasOne(d => d.IdTheNavigation)
                    .WithMany(p => p.PhieuMuons)
                    .HasForeignKey(d => d.IdThe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuMuon__IdThe__49C3F6B7");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.TacGia).HasMaxLength(100);

                entity.Property(e => e.TenSach).HasMaxLength(100);

                entity.Property(e => e.TheLoai)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoVaTen).HasMaxLength(100);

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenTaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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
