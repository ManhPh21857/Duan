using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.IServices;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;

namespace _2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        private IKhachHang _KhachHang = new KhachHangReposi();
        public bool Add(BangKhachHang obj)
        {
            _KhachHang.Add(obj);
            return true;
        }

        public bool Delete(BangKhachHang obj)
        {
            _KhachHang.Delete(obj);
            return true;
        }

        public List<BangKhachHang> GetAll()
        {
            return _KhachHang.GetAll();
        }

        public bool Update(BangKhachHang obj)
        {
            _KhachHang.Update(obj);
            return true;
        }
    }
}
