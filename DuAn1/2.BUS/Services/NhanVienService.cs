using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;
using _2.BUS.IService;
using _1.DAL;
using _2.BUS.ViewModels;
namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVien _iNhanVien = new NhanVienReposi();

        public bool Add(BangNhanVien obj)
        {
            _iNhanVien.Add(obj);
            return true;
        }

        public bool Delete(BangNhanVien obj)
        {
            _iNhanVien.Delete(obj);
            return true;
        }

        public List<BangNhanVien> GetAll()
        {
            return _iNhanVien.GetAll();
        }

        public bool Update(BangNhanVien obj)
        {
            _iNhanVien.Update(obj);
            return true;
        }
    }
}
