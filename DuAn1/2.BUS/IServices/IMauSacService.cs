using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IService
{
    public interface IMauSacService
    {
        bool Add(BangMauSac obj);
        bool Update(BangMauSac obj);
        bool Delete(BangMauSac obj);
        List<BangMauSac> GetAll();
    }
}
