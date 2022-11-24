using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface ICTSanPham
    {
        bool Add(BangChiTietSanPham CTSanPham);
        bool Update(BangChiTietSanPham CTSanPham);
        bool Delete(BangChiTietSanPham CTSanPham);
        List<BangChiTietSanPham> GetAll();
    }
}
