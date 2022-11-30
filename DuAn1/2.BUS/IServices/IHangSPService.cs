using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface IHangSPService
    {
        bool Add(BangHangSanPham obj);
        bool Update(BangHangSanPham obj);
        bool Delete(BangHangSanPham obj);
        List<BangHangSanPham> GetAll();
    }
}
