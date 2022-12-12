using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.IService
{
    public interface IGioHangService
    {
        bool Add(BangGioHang obj);
        bool Update(BangGioHang obj);
        bool Delete(BangGioHang obj);
        List<BangGioHang> GetAll();
        List<GioHangView> GetAllViews();
    }
}
