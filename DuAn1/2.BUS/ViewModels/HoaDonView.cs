using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public BangHoaDon HoaDon { get; set; }
        public BangKhachHang KhachHang { get; set; }
        public BangNhanVien NhanVien { get; set; }

    }
}
