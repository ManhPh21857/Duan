using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class HoaDonReposi : IHoaDon
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangHoaDon HoaDon)
        {
            _dbcontext.bangHoaDons.Add(HoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangHoaDon HoaDon)
        {
            _dbcontext.Remove(HoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangHoaDon> GetAll()
        {
            return _dbcontext.bangHoaDons.ToList();
        }

        public bool Update(BangHoaDon HoaDon)
        {
            _dbcontext.bangHoaDons.Update(HoaDon);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
