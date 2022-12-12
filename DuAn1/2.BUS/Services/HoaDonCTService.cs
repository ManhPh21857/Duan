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
    public class HoaDonCTService : IHoaDonCTService
    {
        private IHoaDonCT _iHoaDonCTReposi = new HoaDonCTReposi();
        private IHoaDon _iHoaDonReposi = new HoaDonReposi();
        private IKhuyenMai _iKhuyenMaiReposi = new KhuyenMaiReposi();
        private ICTSanPham _iCTSanPhamReposi = new ChiTietSPReposi();
        private List<BangChiTietSanPham> _lstCTSanPham = new List<BangChiTietSanPham>();
        public bool Add(BangHoaDonCT obj)
        {
           _iHoaDonCTReposi.Add(obj);
           return true;
        }

        public bool Delete(BangHoaDonCT obj)
        {
            _iHoaDonCTReposi.Delete(obj);
            return true;
        }

        public List<BangHoaDonCT> GetAll()
        {
            return _iHoaDonCTReposi.GetAll();
        }

        public List<HoaDonCTView> GetAllView()
        {
            List<HoaDonCTView> lst = new List<HoaDonCTView>();
            lst = (from a in _iHoaDonCTReposi.GetAll()
                   join b in _iHoaDonReposi.GetAll() on a.IdHoaDon equals b.id
                   join c in _iKhuyenMaiReposi.GetAll() on a.IdHoaDon equals c.Id
                   join d in _iCTSanPhamReposi.GetAll() on a.IdHoaDon equals d.Id

                   select new HoaDonCTView()
                   {
                       HoaDonCT = a,
                       HoaDon = b,
                       KhuyenMai = c,
                       CTSanPham = d,
                   }).ToList();
            return lst;
        }

        
        public bool Update(BangHoaDonCT obj)
        {
            _iHoaDonCTReposi.Update(obj);
            return true;
        }
    }
}
