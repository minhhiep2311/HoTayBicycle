using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class QLThueXeDapContext : DbContext
    {
        public QLThueXeDapContext()
        {
        }

        public QLThueXeDapContext(DbContextOptions<QLThueXeDapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDonThue> ChiTietDonThues { get; set; }
        public virtual DbSet<DatXe> DatXes { get; set; }
        public virtual DbSet<DonThanhToan> DonThanhToans { get; set; }
        public virtual DbSet<DonThue> DonThues { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<XeDap> XeDaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-UO5E52HJ\\SQLEXPRESS;Initial Catalog=QLThueXeDap;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<ChiTietDonThue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChiTietDonThue");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.MaThue).HasMaxLength(255);

                entity.Property(e => e.MaXe).HasMaxLength(255);

                entity.HasOne(d => d.MaThueNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaThue)
                    .HasConstraintName("fk_DonThue_ChiTiet");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("fk_XeDap_ChiTiet");
            });

            modelBuilder.Entity<DatXe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DatXe");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaXe).HasMaxLength(255);

                entity.Property(e => e.NgayDatXe).HasColumnType("datetime");

                entity.Property(e => e.NgayHenLay).HasColumnType("datetime");

                entity.Property(e => e.YeuCau).HasMaxLength(255);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KhachHang_DatXe");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("fk_XeDap_DatXe");
            });

            modelBuilder.Entity<DonThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaDonThanhToan)
                    .HasName("PK__DonThanh__541D87D868960658");

                entity.ToTable("DonThanhToan");

                entity.Property(e => e.MaDonThanhToan).HasMaxLength(255);

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.SoGioSd).HasColumnName("SoGioSD");

                entity.Property(e => e.SoNgaySd).HasColumnName("SoNgaySD");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.TrangThai).HasMaxLength(255);
            });

            modelBuilder.Entity<DonThue>(entity =>
            {
                entity.HasKey(e => e.MaThue)
                    .HasName("PK__DonThue__9CC2FDA366131964");

                entity.ToTable("DonThue");

                entity.Property(e => e.MaThue).HasMaxLength(255);

                entity.Property(e => e.MaDonThanhToan).HasMaxLength(255);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(255)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("MaNV");

                entity.Property(e => e.TrangThai).HasMaxLength(255);

                entity.HasOne(d => d.MaDonThanhToanNavigation)
                    .WithMany(p => p.DonThues)
                    .HasForeignKey(d => d.MaDonThanhToan)
                    .HasConstraintName("fk_DonThue_DonThanhToan");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonThues)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("fk_DonThue_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.DonThues)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("fk_DonThue_NhanVien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1EBD4B944E");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(255)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.SoCccd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SoCCCD");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70A88520BBB");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("MaNV");

                entity.Property(e => e.ChucVu).HasMaxLength(255);

                entity.Property(e => e.Luong).HasColumnType("money");

                entity.Property(e => e.TenNv)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdTaiKhoan)
                    .HasName("PK__TaiKhoan__9A53D3DDE851DF24");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.IdTaiKhoan).HasMaxLength(255);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(255)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("fk_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("fk_NhanVien");
            });

            modelBuilder.Entity<XeDap>(entity =>
            {
                entity.HasKey(e => e.MaXe)
                    .HasName("PK__XeDap__272520CDCA8174D6");

                entity.ToTable("XeDap");

                entity.Property(e => e.MaXe).HasMaxLength(255);

                entity.Property(e => e.GiaThue).HasColumnType("money");

                entity.Property(e => e.NameImage).HasMaxLength(255);

                entity.Property(e => e.TenXe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ThongTinXe).HasMaxLength(255);

                entity.Property(e => e.TrangThai).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
