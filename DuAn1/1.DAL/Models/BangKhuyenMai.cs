using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangKhuyenMai
    {
        public Guid Id { get; set; }
        public string MaKM { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgyaKetThuc { get; set; }
        public float GiamGia { get; set; }
        public string MotaKM { get; set; }
        public int TrangThai  { get; set; } 
    }
}
