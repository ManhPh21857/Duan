using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        bool Add(BangKhachHang obj);
        bool Update(BangKhachHang obj);
        bool Delete(BangKhachHang obj);
        List<BangKhachHang> GetAll();
    }
}
