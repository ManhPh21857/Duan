using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface IHoaDonService
    {
        bool Add(BangHoaDon obj);
        bool Update(BangHoaDon obj);
        bool Delete(BangHoaDon obj);
        List<BangHoaDon> GetAll();
    }
}
