using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IHoaDonCT
    {
        bool Add(BangHoaDonCT HoaDonCT);
        bool Update(BangHoaDonCT HoaDonCT);
        bool Delete(BangHoaDonCT HoaDonCT);
        List<BangHoaDonCT> GetAll();
    }
}
