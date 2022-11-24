using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;
using _2.BUS.IServices;
using _1.DAL;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class ChiTietSPService : IChiTietSPService
    {
        private ICTSanPham _iCTSanPhamReposi = new ChiTietSPReposi();
        private ISanPham _iSanPhamReposi = new SanPhamReposi();
        private IMauSac _iMauSacReposi = new MauSacReposi();
        private IHangSP _iHangSPReposi = new HangSPReposi();
        private ILoaiSP _iLoaiSPReposi = new LoaiSPReposi();
        private List<BangChiTietSanPham> _lstChiTietSP = new List<BangChiTietSanPham>();
        public bool Add(BangChiTietSanPham obj)
        {
            _iCTSanPhamReposi.Add(obj);
            return true;
        }

        public bool Delete(BangChiTietSanPham obj)
        {
            _iCTSanPhamReposi.Delete(obj);
            return true;
        }

        public List<BangChiTietSanPham> GetAll()
        {
            return _iCTSanPhamReposi.GetAll();
        }

        public List<ChiTietSPView> GetAllView()
        {
            List<ChiTietSPView> lst = new List<ChiTietSPView>();
            lst = (from a in _iCTSanPhamReposi.GetAll()
                   join b in _iMauSacReposi.GetAll() on a.IdMauSac equals b.Id
                   join c in _iSanPhamReposi.GetAll() on a.IdSp equals c.Id
                   join d in _iLoaiSPReposi.GetAll() on a.IdLoai equals d.Id
                   join e in _iHangSPReposi.GetAll() on a.IdHang equals e.IdHang
                   select new ChiTietSPView()
                   {
                       ChiTietSP = a,
                       MauSac = b,
                       SanPham = c,
                       LoaiSP = d,
                       HangSP = e
                   }).ToList();
            return lst;
        }

        public bool Update(BangChiTietSanPham obj)
        {
            _iCTSanPhamReposi.Update(obj);
            return true;
        }
    }
}
