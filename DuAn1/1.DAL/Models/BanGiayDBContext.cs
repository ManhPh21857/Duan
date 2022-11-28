using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace _1.DAL.Models
{
    public class BanGiayDBContext : DbContext
    {
        public BanGiayDBContext()
        {

        }
        public BanGiayDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=ANTHONYPC\\SQLEXPRESS;Initial Catalog=duan1;" +
                "Persist Security Info=True;User ID=Linh;Password=123"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<BangChiTietSanPham> bangChiTietSanPhams { get; set; }
        public DbSet<BangChucVu> bangChucVus { get; set; }
        public DbSet<BangDoiTra> bangDoiTras { get; set; }
        public DbSet<BangGioHang> bangGioHangs { get; set; }
        public DbSet<BangGioHangChiTiet> bangGioHangChiTiets { get; set; }
        public DbSet<BangHangSanPham> bangHangSanPhams { get; set; }
        public DbSet<BangHoaDon> bangHoaDons { get; set; }
        public DbSet<BangHoaDonCT> bangHoaDonCTs { get; set; }
        public DbSet<BangKhachHang> bangKhachHangs { get; set; }
        public DbSet<BangKhuyenMai> bangKhuyenMais { get; set; }
        public DbSet<BangLoaiSP> bangLoaiSPs { get; set; }
        public DbSet<BangMauSac> bangMauSacs { get; set; }
        public DbSet<BangNhanVien> bangNhanViens { get; set; }
        public DbSet<BangSanPham> bangSanPhams { get; set; }
    }
}
