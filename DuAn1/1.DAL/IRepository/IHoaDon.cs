using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IHoaDon
    {
        bool Add(BangHoaDon HoaDon);
        bool Update(BangHoaDon HoaDon);
        bool Delete(BangHoaDon HoaDon);
        List<BangHoaDon> GetAll();
    }
}
