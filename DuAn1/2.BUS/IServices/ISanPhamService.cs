using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface ISanPhamService
    {
        bool Add(BangSanPham obj);
        bool Update(BangSanPham obj);
        bool Delete(BangSanPham obj);
        List<BangSanPham> GetAll();
    }
}
