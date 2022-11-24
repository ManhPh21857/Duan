using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class NhanVienReposi : INhanVien
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangNhanVien NhanVien)
        {
            _dbcontext.bangNhanViens.Add(NhanVien);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangNhanVien NhanVien)
        {
            _dbcontext.Remove(NhanVien);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangNhanVien> GetAll()
        {
            return _dbcontext.bangNhanViens.ToList();
        }

        public bool Update(BangNhanVien NhanVien)
        {
            _dbcontext.bangNhanViens.Update(NhanVien);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
