using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;
using _2.BUS.IService;
using _1.DAL;
using _2.BUS.ViewModels;
namespace _2.BUS.Services
{
    public class MauSacService : IMauSacService
    {
        private IMauSac _iMauSac = new MauSacReposi();

        public bool Add(BangMauSac obj)
        {
            _iMauSac.Add(obj);
            return true;
        }

        public bool Delete(BangMauSac obj)
        {
            _iMauSac.Delete(obj);
            return true;
        }

        public List<BangMauSac> GetAll()
        {
            return _iMauSac.GetAll();
        }

        public bool Update(BangMauSac obj)
        {
            _iMauSac.Update(obj);
            return true;
        }
    }
}
