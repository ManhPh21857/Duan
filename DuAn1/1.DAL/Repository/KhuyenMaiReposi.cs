using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class KhuyenMaiReposi : IKhuyenMai
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangKhuyenMai KhuyenMai)
        {
            _dbcontext.bangKhuyenMais.Add(KhuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangKhuyenMai KhuyenMai)
        {
            _dbcontext.Remove(KhuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangKhuyenMai> GetAll()
        {
            return _dbcontext.bangKhuyenMais.ToList();
        }

        public bool Update(BangKhuyenMai KhuyenMai)
        {
            _dbcontext.bangKhuyenMais.Update(KhuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
