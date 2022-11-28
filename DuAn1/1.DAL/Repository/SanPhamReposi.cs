using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL
{
    public class SanPhamReposi : ISanPham
    {
        private BanGiayDBContext _dbcontext = new BanGiayDBContext();

        public bool Add(BangSanPham SanPham)
        {
            _dbcontext.bangSanPhams.Add(SanPham);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangSanPham SanPham)
        {
            _dbcontext.bangSanPhams.Remove(SanPham);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangSanPham> GetAll()
        {
            return _dbcontext.bangSanPhams.ToList();
        }

        public bool Update(BangSanPham SanPham)
        {
            _dbcontext.bangSanPhams.Update(SanPham);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
