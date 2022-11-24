using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class HangSPReposi : IHangSP
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangHangSanPham HangSP)
        {
            _dbcontext.bangHangSanPhams.Add(HangSP);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangHangSanPham HangSP)
        {
            _dbcontext.Remove(HangSP);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangHangSanPham> GetAll()
        {
            return _dbcontext.bangHangSanPhams.ToList();
        }

        public bool Update(BangHangSanPham HangSP)
        {
            _dbcontext.bangHangSanPhams.Update(HangSP);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
