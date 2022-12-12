using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.IService
{
    public interface IHoaDonService
    {
        bool Add(BangHoaDon obj);
        bool Update(BangHoaDon obj);
        bool Delete(BangHoaDon obj);
        List<BangHoaDon> GetAll();
        List<HoaDonView> GetAllView();
    }
}
