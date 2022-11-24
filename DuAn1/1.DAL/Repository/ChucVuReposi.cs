using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class ChucVuReposi : IChucVu
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangChucVu ChucVu)
        {
            _dbcontext.bangChucVus.Add(ChucVu);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangChucVu ChucVu)
        {
            _dbcontext.Remove(ChucVu);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangChucVu> GetAll()
        {
            return _dbcontext.bangChucVus.ToList();
        }

        public bool Update(BangChucVu ChucVu)
        {
            _dbcontext.bangChucVus.Update(ChucVu);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
