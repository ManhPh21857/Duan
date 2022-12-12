using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.IService;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.Service
{
    public class GioHangCTService : IGioHangCTService
        
    {
        private IGioHangCT _iGioHangCTRepository = new GioHangCTReposi();
        private ICTSanPham _iChiTietSPRepository = new ChiTietSPReposi();
        private IGioHang _iGioHangRepository = new GioHangReposi();
        public bool Add(BangGioHangChiTiet obj)
        {
            _iGioHangCTRepository.Add(obj);
            return true;
        }

        public bool Delete(BangGioHangChiTiet obj)
        {
            _iGioHangCTRepository.Delete(obj);
            return true;
        }

        public List<BangGioHangChiTiet> GetAll()
        {
            return _iGioHangCTRepository.GetAll();
        }

        public bool Update(BangGioHangChiTiet obj)
        {
            _iGioHangCTRepository.Update(obj);
            return true;
        }
        public List<GioHangCTView> GetAllViews()
        {
            List<GioHangCTView> lst = new List<GioHangCTView>();
            lst = (from a in _iGioHangCTRepository.GetAll()
                   join b in _iChiTietSPRepository.GetAll() on a.IdCTSP equals b.Id
                   join c in _iGioHangRepository.GetAll() on a.IdGioHang equals c.Id
                   select new GioHangCTView()
                   {
                       GioHangCT = a,
                       CTSanPham = b,
                       GioHang = c
                   }).ToList();
            return lst;
        }
    }
}
