using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IHangSP
    {
        bool Add(BangHangSanPham HangSP);
        bool Update(BangHangSanPham HangSP);
        bool Delete(BangHangSanPham HangSP);
        List<BangHangSanPham> GetAll();
    }
}
