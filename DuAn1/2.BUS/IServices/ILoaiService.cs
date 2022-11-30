using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface ILoaiService
    {
        bool Add(BangLoaiSP obj);
        bool Update(BangLoaiSP obj);
        bool Delete(BangLoaiSP obj);
        List<BangLoaiSP> GetAll();
    }
}
