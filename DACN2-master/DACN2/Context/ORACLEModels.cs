using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DACN2.Context
{
    public partial class ORACLEModels : DbContext
    {
        public ORACLEModels()
            : base("name=ORACLEModels")
        {
        }

        public virtual DbSet<CHANG> CHANGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CTHOPDONGTOUR> CTHOPDONGTOURs { get; set; }
        public virtual DbSet<DANHGIA> DANHGIAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAITOUR> LOAITOURs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TINTUC> TINTUCs { get; set; }
        public virtual DbSet<TOUR> TOURs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHANG>()
                .Property(e => e.MACHANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CHANG>()
                .Property(e => e.MATOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.TENCV)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOPDONGTOUR>()
                .Property(e => e.SONGUOILON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CTHOPDONGTOUR>()
                .Property(e => e.SOTREEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CTHOPDONGTOUR>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DANHGIA>()
                .Property(e => e.MADG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DANHGIA>()
                .Property(e => e.MAKHACHHANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DANHGIA>()
                .Property(e => e.MATOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHOPDONG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MAKHACHHANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.SOCHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MATOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MANV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.CTHOPDONGTOURs)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKHACHHANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DANHGIAs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITOUR>()
                .Property(e => e.MALOAITOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TINTUC>()
                .Property(e => e.IDTINTUC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TINTUC>()
                .Property(e => e.MANV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.MATOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.SOCHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.MALOAITOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.MANV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TOUR>()
                .HasMany(e => e.CTHOPDONGTOURs)
                .WithRequired(e => e.TOUR)
                .WillCascadeOnDelete(false);
        }
    }
}
