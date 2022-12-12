using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.IService
{
    public interface IHoaDonCTService
    {
        bool Add(BangHoaDonCT obj);
        bool Update(BangHoaDonCT obj);
        bool Delete(BangHoaDonCT obj);
        List<BangHoaDonCT> GetAll();
        List<HoaDonCTView> GetAllView();
    }
}
