using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.IService
{
    public interface IDoiTraService
    {
        bool Add(BangDoiTra obj);
        bool Update(BangDoiTra obj);
        bool Delete(BangDoiTra obj);
        List<BangDoiTra> GetAll();
    }
}
