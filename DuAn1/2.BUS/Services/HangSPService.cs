using _1.DAL.IReposi;
using _1.DAL.Repository;
using _1.DAL.Models;
using _1.DAL;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.IService;

namespace _2.BUS.Services
{
    public class HangSPService : IHangSPService
    {
        private IHangSP _iHangSp = new HangSPReposi();

        public bool Add(BangHangSanPham obj)
        {
            _iHangSp.Add(obj);
            return true;
        }

        public bool Delete(BangHangSanPham obj)
        {
            _iHangSp.Delete(obj);
            return true;
        }

        public List<BangHangSanPham> GetAll()
        {
            return _iHangSp.GetAll();
        }

        public bool Update(BangHangSanPham obj)
        {
            _iHangSp.Update(obj);
            return true;
        }
    }
}
