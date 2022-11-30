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
    public class KhuyenMaiService : IKhuyenMaiService
    {
        private IKhuyenMai _iKhuyenMai = new KhuyenMaiReposi();

        public bool Add(BangKhuyenMai obj)
        {
            _iKhuyenMai.Add(obj);
            return true;
        }

        public bool Delete(BangKhuyenMai obj)
        {
            _iKhuyenMai.Delete(obj);
            return true;
        }

        public List<BangKhuyenMai> GetAll()
        {
            return _iKhuyenMai.GetAll();
        }

        public bool Update(BangKhuyenMai obj)
        {
            _iKhuyenMai.Update(obj);
            return true;
        }
    }
}
