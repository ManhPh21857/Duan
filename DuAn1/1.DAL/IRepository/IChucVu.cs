using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IChucVu
    {
        bool Add(BangChucVu ChucVu);
        bool Update(BangChucVu ChucVu);
        bool Delete(BangChucVu ChucVu);
        List<BangChucVu> GetAll();
    }
}
