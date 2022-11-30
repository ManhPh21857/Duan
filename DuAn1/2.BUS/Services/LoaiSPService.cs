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
    public class LoaiSPService : ILoaiService
    {
        private ILoaiSP _iLoaiSPReposi = new LoaiSPReposi();
        private List<BangLoaiSP> _lstLoaiSP = new List<BangLoaiSP>();

        public bool Add(BangLoaiSP obj)
        {
            _iLoaiSPReposi.Add(obj);
            return true;
        }

        public bool Delete(BangLoaiSP obj)
        {
            _iLoaiSPReposi.Delete(obj);
            return true;
        }

        public List<BangLoaiSP> GetAll()
        {
            return _iLoaiSPReposi.GetAll();
        }

        public bool Update(BangLoaiSP obj)
        {
            _iLoaiSPReposi.Update(obj);
            return true;
        }
    }

}
