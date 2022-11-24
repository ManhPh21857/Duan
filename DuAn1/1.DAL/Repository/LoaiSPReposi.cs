using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class LoaiSPReposi : ILoaiSP
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangLoaiSP LoaiSP)
        {
            _dbcontext.bangLoaiSPs.Add(LoaiSP);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangLoaiSP LoaiSP)
        {
            _dbcontext.Remove(LoaiSP);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangLoaiSP> GetAll()
        {
            return _dbcontext.bangLoaiSPs.ToList();
        }

        public bool Update(BangLoaiSP LoaiSP)
        {
            _dbcontext.bangLoaiSPs.Update(LoaiSP);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
