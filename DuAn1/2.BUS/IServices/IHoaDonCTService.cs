using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface IHoaDonCTService
    {
        bool Add(BangHoaDonCT obj);
        bool Update(BangHoaDonCT obj);
        bool Delete(BangHoaDonCT obj);
        List<BangHoaDonCT> GetAll();
    }
}
