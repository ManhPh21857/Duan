using _1.DAL.IReposi;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        private IHoaDon _iHoaDonReposi = new HoaDonReposi();
        private IKhachHang _iKhachHangReposi = new KhachHangReposi();
        private INhanVien _iNhanVienreposi = new NhanVienReposi();
        private List<BangHoaDon> _lstHoaDon = new List<BangHoaDon>();
        public bool Add(BangHoaDon obj)
        {
            _iHoaDonReposi.Add(obj);
            return true;
        }

        public bool Update(BangHoaDon obj)
        {
            _iHoaDonReposi.Update(obj);
            return true;
        }

        public bool Delete(BangHoaDon obj)
        {
            _iHoaDonReposi.Delete(obj);
            return true;
        }

        public List<BangHoaDon> GetAll()
        {
            return _iHoaDonReposi.GetAll();
        }

        public List<HoaDonView> GetHoaDonfromDB()
        {
            List<HoaDonView> lst = new List<HoaDonView>();
            lst = (from a in _iHoaDonReposi.GetAll()
                   join b in _iKhachHangReposi.GetAll() on a.IdKH equals b.Id
                   join c in _iNhanVienreposi.GetAll() on a.IdNV equals c.Id
                   
                   select new HoaDonView()
                   {
                       HoaDon = a,
                       KhachHang = b,
                       NhanVien = c,                      
                   }).ToList();
            return lst;
        }

       
    }
}
