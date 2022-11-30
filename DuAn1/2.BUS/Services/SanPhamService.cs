using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _2.BUS.IService;
using _1.DAL;

namespace _2.BUS.Services
{
    public class SanPhamService : ISanPhamService
    {
        private ISanPham sanPham = new SanPhamReposi();
        public bool Add(BangSanPham obj)
        {
            sanPham.Add(obj);
            return true;
        }

        public bool Delete(BangSanPham obj)
        {
            sanPham.Delete(obj);
            return true;
        }

        public List<BangSanPham> GetAll()
        {
            return sanPham.GetAll();
        }

        public bool Update(BangSanPham obj)
        {
            sanPham.Update(obj);
            return true;
        }
    }
}
