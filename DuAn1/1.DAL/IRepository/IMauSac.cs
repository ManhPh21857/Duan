using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _1.DAL.IReposi
{
    public interface IMauSac
    {
        bool Add(BangMauSac MauSac);
        bool Update(BangMauSac MauSac);
        bool Delete(BangMauSac MauSac);
        List<BangMauSac> GetAll();
    }
}
