using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class KhachHangReposi : IKhachHang
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangKhachHang KhachHang)
        {
            _dbcontext.bangKhachHangs.Add(KhachHang);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangKhachHang KhachHang)
        {
            _dbcontext.Remove(KhachHang);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangKhachHang> GetAll()
        {
            return _dbcontext.bangKhachHangs.ToList();
        }

        public bool Update(BangKhachHang KhachHang)
        {
            _dbcontext.bangKhachHangs.Update(KhachHang);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
