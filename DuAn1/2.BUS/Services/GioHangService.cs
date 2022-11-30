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
    public class GioHangService : IGioHangService
    {
        private IGioHang _iGioHangRepository = new GioHangReposi();
        private INhanVien _iNhanVienRepository = new NhanVienReposi();
        private IKhachHang _iKhachHangRepository = new KhachHangReposi();


        public bool Add(BangGioHang obj)
        {
            _iGioHangRepository.Add(obj);
            return true;
        }

        public bool Delete(BangGioHang obj)
        {
            _iGioHangRepository.Delete(obj);
            return true;
        }

        public List<BangGioHang> GetAll()
        {
            return _iGioHangRepository.GetAll();
        }

        public bool Update(BangGioHang obj)
        {
            _iGioHangRepository.Update(obj);
            return true;
        }
        public List<GioHangView> GetAllView()
        {
           List<GioHangView> lst = new List<GioHangView>();
            lst = (from a in _iGioHangRepository.GetAll() join b in _iKhachHangRepository.GetAll() on a.IdKH equals b.Id join c in _iNhanVienRepository.GetAll() on a.IdNV equals c.Id 
               select new GioHangView()
               {
                   GioHang = a ,
                   KhachHang = b,
                   NhanVien = c
               }    ).ToList();
            return lst;
        }

    }
}
