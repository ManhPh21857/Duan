using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangNhanVien
    {
        public Guid Id { get; set; }
        public Guid IdCV { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenDem { get; set; }
        public string Ho { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public virtual BangChucVu ChucVu { get; set; }

    }
}
