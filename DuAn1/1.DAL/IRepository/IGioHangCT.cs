using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IGioHangCT
    {
        bool Add(BangGioHangChiTiet GioHangCT);
        bool Update(BangGioHangChiTiet GioHangCT);
        bool Delete(BangGioHangChiTiet GioHangCT);
        List<BangGioHangChiTiet> GetAll();
    }
}
