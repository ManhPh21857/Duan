using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class GioHangCTReposi : IGioHangCT
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangGioHangChiTiet GioHangCT)
        {
            _dbcontext.bangGioHangChiTiets.Add(GioHangCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangGioHangChiTiet GioHangCT)
        {
            _dbcontext.Remove(GioHangCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangGioHangChiTiet> GetAll()
        {
            return _dbcontext.bangGioHangChiTiets.ToList();
        }

        public bool Update(BangGioHangChiTiet GioHangCT)
        {
            _dbcontext.bangGioHangChiTiets.Update(GioHangCT);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
