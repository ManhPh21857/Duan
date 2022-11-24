using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class ChiTietSPReposi : ICTSanPham
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangChiTietSanPham CTSanPham)
        {
            _dbcontext.bangChiTietSanPhams.Add(CTSanPham);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangChiTietSanPham CTSanPham)
        {
            _dbcontext.Remove(CTSanPham);
            _dbcontext.SaveChanges();
            return true;
        }
        public List<BangChiTietSanPham> GetAll()
        {
           return _dbcontext.bangChiTietSanPhams.ToList();
        }

        public bool Update(BangChiTietSanPham CTSanPham)
        {
            _dbcontext.bangChiTietSanPhams.Update(CTSanPham);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
