using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.ViewModels
{
    public class HoaDonCTView
    {
        public BangHoaDonCT HoaDonCT { get; set; }
        public BangHoaDon HoaDon { get; set; }
        public BangKhuyenMai KhuyenMai { get; set; }
        public BangChiTietSanPham CTSanPham { get; set; }
    }
}
