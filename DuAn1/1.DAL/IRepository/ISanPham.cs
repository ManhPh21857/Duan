using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface ISanPham
    {
        bool Add(BangSanPham SanPham);
        bool Update(BangSanPham SanPham);
        bool Delete(BangSanPham SanPham);
        List<BangSanPham> GetAll();
    }
}
