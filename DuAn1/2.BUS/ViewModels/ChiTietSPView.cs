using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.ViewModels
{
    public class ChiTietSPView
    {
        public BangChiTietSanPham ChiTietSP { get; set; }
        public BangMauSac MauSac { get; set; }
        public BangHangSanPham HangSP { get; set; }
        public BangSanPham SanPham { get; set; }
        public BangLoaiSP LoaiSP { get; set; }
    }
}
