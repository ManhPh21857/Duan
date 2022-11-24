using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IDoiTra
    {
        bool Add(BangDoiTra DoiTra);
        bool Update(BangDoiTra DoiTra);
        bool Delete(BangDoiTra DoiTra);
        List<BangDoiTra> GetAll();
    }
}
