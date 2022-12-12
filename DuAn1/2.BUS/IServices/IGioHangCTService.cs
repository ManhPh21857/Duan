using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.IService
{
    public interface IGioHangCTService
    {
        bool Add(BangGioHangChiTiet obj);
        bool Update(BangGioHangChiTiet obj);
        bool Delete(BangGioHangChiTiet obj);
        List<BangGioHangChiTiet> GetAll();
        List<GioHangCTView> GetAllViews();
    }
}
