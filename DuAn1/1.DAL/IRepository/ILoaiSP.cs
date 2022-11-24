using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface ILoaiSP
    {
        bool Add(BangLoaiSP LoaiSP);
        bool Update(BangLoaiSP LoaiSP);
        bool Delete(BangLoaiSP LoaiSP);
        List<BangLoaiSP> GetAll();
    }
}
