using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IKhuyenMai
    {
        bool Add(BangKhuyenMai KhuyenMai);
        bool Update(BangKhuyenMai KhuyenMai);
        bool Delete(BangKhuyenMai KhuyenMai);
        List<BangKhuyenMai> GetAll();
    }
}
