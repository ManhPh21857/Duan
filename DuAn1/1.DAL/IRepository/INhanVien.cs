using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface INhanVien
    {
        bool Add(BangNhanVien NhanVien);
        bool Update(BangNhanVien NhanVien);
        bool Delete(BangNhanVien NhanVien);
        List<BangNhanVien> GetAll();
    }
}
