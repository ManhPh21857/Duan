using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IKhachHang
    {
        bool Add(BangKhachHang KhachHang);
        bool Update(BangKhachHang KhachHang);
        bool Delete(BangKhachHang KhachHang);
        List<BangKhachHang> GetAll();
    }
}
