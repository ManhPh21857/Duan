
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.ViewModels
{
    public class GioHangCTView
    {
        public BangGioHangChiTiet GioHangCT { get; set; }
        public BangGioHang GioHang { get; set; }
        public BangChiTietSanPham CTSanPham { get; set; }

    }
}
