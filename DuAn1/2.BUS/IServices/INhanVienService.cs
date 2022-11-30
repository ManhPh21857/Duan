using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface INhanVienService
    {
        bool Add(BangNhanVien obj);
        bool Update(BangNhanVien obj);
        bool Delete(BangNhanVien obj);
        List<BangNhanVien> GetAll();
    }
}
