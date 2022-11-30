using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.IServices
{
    public interface IKhuyenMaiService
    {
        bool Add(BangKhuyenMai obj);
        bool Update(BangKhuyenMai obj);
        bool Delete(BangKhuyenMai obj);
        List<BangKhuyenMai> GetAll();
    }
}
