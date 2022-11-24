using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IGioHang
    {
        bool Add(BangGioHang GioHang);
        bool Update(BangGioHang GioHang);
        bool Delete(BangGioHang GioHang);
        List<BangGioHang> GetAll();
    }
}
