using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using Amazon.SimpleWorkflow.Model;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Extensions
{
    public static class ModelbuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangSanPham>().HasData(

               new BangSanPham() {  MaSP = "c3ef7dfc-8915-437e-8897-deb4288c3574", TenSP = "Giày Thể Thao"},
               new BangSanPham() { MaSP = "f76ee3e7-e818-49cc-822e-a7142192dbce", TenSP = "Giày Du Mục"},
               new BangSanPham() {  MaSP = "d68187f0-f714-4321-8be2-c1371cb8a13a", TenSP = "Giày Hiệp Sỹ"},
               new BangSanPham() {  MaSP = "7df9f624-80e0-458c-b6be-3024d6bc6bc6", TenSP = "Giày Kiên Cường"},
               new BangSanPham() {  MaSP = "6c9e926b-c97d-4922-aca8-909831fb6a59", TenSP = "Giày Hộ Vệ"}
                ) ;
            modelBuilder.Entity<BangLoaiSP>().HasData(
                new BangLoaiSP() { MaLoai = "3ea19778-dde3-480c-8620-e70ec427de35", TenLoai = "Giày Thể Thao" },
                new BangLoaiSP() { MaLoai = "a6ae2bf5-7a49-4d74-b160-b75ba2e987bb", TenLoai = "Giày Du Mục" },
                new BangLoaiSP() { MaLoai = "3b171b18-96f0-43e3-9ca4-711189825354", TenLoai = "Giày Hiệp Sỹ" },
                new BangLoaiSP() { MaLoai = "bdb2ffc7-8e3c-47f1-bfae-db4fe6e1a0b7", TenLoai = "Giày Kiên Cường" },
                new BangLoaiSP() { MaLoai = "2e2ac9a2-e086-4f0f-8bd5-161ce627b34b", TenLoai = "Giày Hộ Vệ" }
            );
            modelBuilder.Entity<BangMauSac>().HasData(
                    new BangMauSac() { MaMs = "5918e7bf-c8ff-4151-977a-01fa54a68d27", TenMs = "Xanh" },
                    new BangMauSac() { MaMs = "6c3c542e-5d95-4c2f-a004-27bf440f845c", TenMs = "Đỏ" },
                    new BangMauSac() { MaMs = "b0320323-9a80-4b33-bb9d-d6b829039a64", TenMs = "Tím" },
                    new BangMauSac() { MaMs = "4f09c127-8991-4881-9ee4-9d801c0776f2", TenMs = "Vàng" },
                    new BangMauSac() { MaMs = "ad0ed8ac-9de9-448b-9f5a-b1cd4e4c5e06", TenMs = "Trắng" }
                ) ;
            modelBuilder.Entity<BangHangSanPham>().HasData(
                    new BangHangSanPham() { MaHang = "14e051b1-0601-415d-be03-241d60663a89", TenHang= "Adidas"},
                    new BangHangSanPham() { MaHang = "bf715726-612b-4039-9ed9-d4b4175aaf8c", TenHang= "Puma"},
                    new BangHangSanPham() { MaHang = "bf76abab-09e8-45cc-9814-a3e9b1cd8130", TenHang= "Nike"},
                    new BangHangSanPham() { MaHang = "61890671-2af1-4445-8129-f5db8f91fc66", TenHang= "Thượng Đỉnh"},
                    new BangHangSanPham() { MaHang = "168ef6d4-fa49-45f0-9b1d-e9173523a927", TenHang= "Gucci"}
                );
            modelBuilder.Entity<BangChucVu>().HasData(
                    new BangChucVu() { MaCV = "CV01" , TenCV = "Quản Lý"},
                    new BangChucVu() { MaCV = "CV02" , TenCV = "Nhân Viên"}
                );
            modelBuilder.Entity<BangKhuyenMai>().HasData(
                    new BangKhuyenMai() { MaKM = "b9c838ee-53f0-4b41-a39e-46c27585afc0", MotaKM = "Mừng Bạn Mới" },
                    new BangKhuyenMai() { MaKM = "6161cfad-6e92-4a8e-ae45-43542500af79", MotaKM = "Black friday" },
                    new BangKhuyenMai() { MaKM = "9977ec62-aa63-4a5a-b291-e743dd165e57", MotaKM = "Sale khai trương cửa hàng" },
                    new BangKhuyenMai() { MaKM = "11756abf-cdda-42ec-a283-ab9c0db6bf1b", MotaKM = "Sale Cuối Năm" },
                    new BangKhuyenMai() { MaKM = "44b40f2c-bed0-42f7-88c1-97d8ef744190", MotaKM = "Sale Xả Kho" }
                );
            modelBuilder.Entity<BangKhachHang>().HasData(
                    new BangKhachHang() { Ma = "7eb6cc4a-0c52-4209-b86a-59583cc73eba", Ho = "Nguyễn",TenDem = "Thị",Ten = "Huyền",SDT = "0325145698",DiaChi = "Cầy Giấy - Hà Nội",GioiTinh = "Nữ",MatKhau = "111"},
                    new BangKhachHang() { Ma = "fb9d708c-6b88-46a1-b97c-547bea5b3785", Ho = "Trần",TenDem = "Thị",Ten = "Trang",SDT = "0235448521",DiaChi = "Thanh Xuân - Hà Nội",GioiTinh = "Nữ",MatKhau = "222"},
                    new BangKhachHang() { Ma = "03e9b177-72b6-42b2-85e9-9f1d0a74a76c", Ho = "Lê",TenDem = "Văn",Ten = "Thinh",SDT = "0385216265",DiaChi = "Hoàng Mai - Hà Nội",GioiTinh = "Nam",MatKhau = "333"},
                    new BangKhachHang() { Ma = "04dc71db-f988-4b1a-8464-7392f8199534", Ho = "Hoàng",TenDem = "Văn",Ten = "Đại",SDT = "0521635842",DiaChi = "Minh Khai - Hà Nội",GioiTinh = "Nam",MatKhau = "444"},
                    new BangKhachHang() { Ma = "e0d66516-9595-4d89-b2f8-0f3ef8bca686", Ho = "Vũ",TenDem = "Thị",Ten = "Hoa",SDT = "0693215479",DiaChi = "Đống Đa - Hà Nội",GioiTinh = "Nữ",MatKhau = "555"}
                );
            modelBuilder.Entity<ba>

        }
    }
}
