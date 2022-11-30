using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface IGioHangCTService
    {
        bool Add(BangGioHangChiTiet obj);
        bool Update(BangGioHangChiTiet obj);
        bool Delete(BangGioHangChiTiet obj);
        List<BangGioHangChiTiet> GetAll();
    }
}
