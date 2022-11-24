using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class HoaDonCTReposi : IHoaDonCT
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangHoaDonCT HoaDonCT)
        {
            _dbcontext.bangHoaDonCTs.Add(HoaDonCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangHoaDonCT HoaDonCT)
        {
            _dbcontext.Remove(HoaDonCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangHoaDonCT> GetAll()
        {
            return _dbcontext.bangHoaDonCTs.ToList();
        }

        public bool Update(BangHoaDonCT HoaDonCT)
        {
            _dbcontext.bangHoaDonCTs.Update(HoaDonCT);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
