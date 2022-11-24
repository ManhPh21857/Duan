using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;
namespace _2.BUS.IServices
{
    public interface IChiTietSPService
    {
        bool Add(BangChiTietSanPham obj);
        bool Update(BangChiTietSanPham obj);
        bool Delete(BangChiTietSanPham obj);

        List<ChiTietSPView> GetAllView();
        List<BangChiTietSanPham> GetAll();
    }
}
