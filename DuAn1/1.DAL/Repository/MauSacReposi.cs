using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Models;

namespace _1.DAL.Repository
{
    public class MauSacReposi : IMauSac
    {
        BanGiayDBContext _dbcontext = new BanGiayDBContext();
        public bool Add(BangMauSac MauSac)
        {
            _dbcontext.bangMauSacs.Add(MauSac);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BangMauSac MauSac)
        {
            _dbcontext.Remove(MauSac);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<BangMauSac> GetAll()
        {
            return _dbcontext.bangMauSacs.ToList();
        }

        public bool Update(BangMauSac MauSac)
        {
            _dbcontext.bangMauSacs.Update(MauSac);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
