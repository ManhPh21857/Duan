using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class DoiTraReposi : IDoiTra
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangDoiTra DoiTra)
        {
            _dbcontext.bangDoiTras.Add(DoiTra);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangDoiTra DoiTra)
        {
            _dbcontext.Remove(DoiTra);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangDoiTra> GetAll()
        {
            return _dbcontext.bangDoiTras.ToList();
        }

        public bool Update(BangDoiTra DoiTra)
        {
            _dbcontext.bangDoiTras.Update(DoiTra);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
