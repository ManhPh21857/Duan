using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class GioHangReposi : IGioHang
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangGioHang GioHang)
        {
            _dbcontext.bangGioHangs.Add(GioHang);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangGioHang GioHang)
        {
            _dbcontext.Remove(GioHang);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangGioHang> GetAll()
        {
            return _dbcontext.bangGioHangs.ToList();
        }

        public bool Update(BangGioHang GioHang)
        {
            _dbcontext.bangGioHangs.Update(GioHang);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
