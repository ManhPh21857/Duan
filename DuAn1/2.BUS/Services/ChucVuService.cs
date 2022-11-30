using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using _1.DAL.Repository;
using _1.DAL.IReposi;
namespace _2.BUS.Services
{
    public class ChucVuService : IChucVuService
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        private IChucVu _ChucVu = new ChucVuReposi();
        public bool Add(BangChucVu obj)
        {
            _ChucVu.Add(obj);
            return true;
        }

        public bool Delete(BangChucVu obj)
        {
           _ChucVu.Delete(obj);
            return true;
        }

        public List<BangChucVu> GetAll()
        {
            return _ChucVu.GetAll();
        }

        public bool Update(BangChucVu obj)
        {
            _ChucVu.Update(obj);
            return true;
        }
    }
}
