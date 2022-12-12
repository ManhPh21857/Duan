using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  _2.BUS.ViewModels;
using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.IServices;
using _2.BUS.Service;
using _1.DAL.Repository;
using _3.Presentation;
namespace _3.PL.ViewsFrm
{
    public partial class FrmThongKe : Form
    {
        IHoaDonCTService ihoadonchitietservice;
        INhanVienService inhanvienservice;
        IChiTietSPService ichitietsanphamservice;
        IGioHangCTService igiohangchitietservice;
        IKhachHangService ikhachhangservice;
        IHoaDonService ihoadonservice;
        IKhuyenMaiService ikhuyenmaiservice;
        ISanPhamService isanphamservice;
        List<BangHoaDon> _lstHoaDon;
        List<BangHoaDonCT> _lstHoaDonCT;
        List<BangChiTietSanPham> _lstChiTietSanPham;
        List<BangNhanVien> _lstNhanVien;

        FrmBanHang banhang = new FrmBanHang();
        public FrmThongKe()
        {
            InitializeComponent();
            ihoadonchitietservice = new HoaDonCTService();
            inhanvienservice = new NhanVienService();
            ichitietsanphamservice = new ChiTietSPService();
            igiohangchitietservice = new GioHangCTService();
            ikhachhangservice = new KhachHangService();
            ihoadonservice = new HoaDonService();
            ikhuyenmaiservice = new KhuyenMaiService();
            isanphamservice = new SanPhamService();
            _lstHoaDon = new List<BangHoaDon>();
            _lstHoaDonCT = new List<BangHoaDonCT>();
            _lstChiTietSanPham = new List<BangChiTietSanPham>();
            _lstNhanVien = new List<BangNhanVien>();
            txb_loaispyeuthichnhat.ReadOnly = true;
            txb_ten_sp_yeuthichnhat.ReadOnly = true;
            txb_tongslton.ReadOnly = true;
            txb_tongsotien.ReadOnly = true;

            LoadSanPhamVaDoanhThu();
            LoadDate();
            LoadNhanVien();
            LoadDonHang();
            LoadKhachHang();
            LoadThanhTichNhanVien();
        }
        public void LoadDate()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbb_thang.Items.Add(i);
            }
            for (int i = Convert.ToInt32(ihoadonservice.GetAll().First().NgayTao.ToString("yyyy")); i <= Convert.ToInt32(ihoadonservice.GetAll().Last().NgayTao.ToString("yyyy")); i++)
            {
                cbb_nam.Items.Add(i);
            }
        }
        public void LoadSanPhamVaDoanhThu()
        {
            dtg_sanpham.ColumnCount = 8;
            dtg_sanpham.Columns[0].Name = "Mã Sản Phẩm";
            dtg_sanpham.Columns[1].Name = "Tên Sản Phẩm";
            dtg_sanpham.Columns[2].Name = "Màu Sản Phẩm";
            dtg_sanpham.Columns[3].Name = "hãng Sản Phẩm";
            dtg_sanpham.Columns[4].Name = "Loại Sản Phẩm";
            dtg_sanpham.Columns[5].Name = "Số Lượng Mua";
            dtg_sanpham.Columns[6].Name = "Số Lượng Tồn";
            dtg_sanpham.Columns[7].Name = "Đơn Giá";
            dtg_sanpham.Rows.Clear();
            var x = (from a in ichitietsanphamservice.GetAll()
                     join b in isanphamservice.GetAll() on a.IdSp equals b.Id
                     join c in ihoadonchitietservice.GetAll() on a.Id equals c.IDCTSP
                     join d in _lstHoaDon on c.IdHoaDon equals d.id
                    // join e in ikhuyenmaiservice.GetAll() on c.IDKM equals d.Id
                     select new { a, b, c, d
                                      });
           
            foreach (var item in x)
            {
                dtg_sanpham.Rows.Add(item.b.MaSP,
                    item.b.TenSP, 
                    item.a.MauSac,
                    item.a.HangSP, 
                    item.a.LoaiSP, 
                    item.c.SoLuong,
                    item.a.Soluongton,
                    item.c.DonGia
                    );
            }
           // txb_ten_sp_yeuthichnhat.Text = x.Select(x => x.c.SoLuong).Count().ToString();// sai
            txb_tongslton.Text = x.Select(x => x.a).Distinct().Sum(x => x.Soluongton).ToString();
            txb_tongsotien.Text = x.Select(x => x.c).Distinct().Sum(x => x.DonGia).ToString();
            //txb_ten_sp_yeuthichnhat = x.Select(x => x.b.TenSP).Where(x => )
           

        }
        public void LoadNhanVien()
        {
            lb_tongnv.Text = inhanvienservice.GetAll().Select(x => x.Ma).Count().ToString();
            foreach (var item in inhanvienservice.GetAll())
            {
                cbb_nv.Items.Add(string.Concat(item.Ten," ", item.TenDem," ", item.Ho));
            }
            var x = (from a in inhanvienservice.GetAll()
                     join b in ihoadonservice.GetAll() on a.Id equals b.IdNV
                     join c in ikhachhangservice.GetAll() on b.IdKH equals c.Id
                     select new { a, b, c });
            lb_sohoadon.Text = x.Select(x => x.b.Ma).Where( x => x.Contains(cbb_nv.Text)).Count().ToString();
            lb_sokh.Text = x.Select(x => x.c.Ma).Where(x => x.Contains(cbb_nv.Text)).Count().ToString();
        }
        public void LoadDonHang()
        {
            lb_tongdonhang.Text = ihoadonservice.GetAll().Select(x => x.Ma).Count().ToString();
            //lb_donhangchuathanhtoan.Text = ihoadonservice.GetAll().Select(x => x.Ma).Where(x => x.).ToString();
        }
        public void LoadKhachHang()
        {
            var x = (from a in ikhachhangservice.GetAll()
                     join b in ihoadonservice.GetAll() on a.Id equals b.IdKH
                     //join c in ihoadonchitietservice.GetAll() on b.id equals c.IdHoaDon
                     select new { a, b, //c
                                        });
            dtg_khach_hangthanthiet.ColumnCount = 4;
            dtg_khach_hangthanthiet.Columns[0].Name = "Mã Khách Hàng";
            dtg_khach_hangthanthiet.Columns[1].Name = "Tên Khách Hàng";
            dtg_khach_hangthanthiet.Columns[2].Name = "Địa Chỉ";
            dtg_khach_hangthanthiet.Columns[3].Name = "Số Lượng Mua";
            dtg_khach_hangthanthiet.Rows.Clear();
            foreach (var item in x)
            {
                dtg_khach_hangthanthiet.Rows.Add(item.a.Ma, string.Concat(item.a.Ho," ",item.a.TenDem," ",item.a.Ten),item.a.DiaChi//,item.c.SoLuong/
                                                                                                                                   );
            }
        }

        private void cbb_nam_TextChanged(object sender, EventArgs e)
        {
            _lstHoaDon = ihoadonservice.GetAll().Where(x => x.NgayThanhToan.Year.ToString() == cbb_nam.Text).ToList();
            LoadSanPhamVaDoanhThu();
        }

        private void cbb_thang_TextChanged(object sender, EventArgs e)
        {
           if(cbb_nam.Text != "")
            {
                _lstHoaDon = ihoadonservice.GetAll().Where(x => (x.NgayThanhToan.Year.ToString() == cbb_nam.Text && x.NgayThanhToan.Month.ToString() == cbb_thang.Text)).ToList();
                LoadSanPhamVaDoanhThu();
            }
        }
        public void LoadThanhTichNhanVien()
        {
            var x = (from a in _lstNhanVien
                     join b in ihoadonservice.GetAll() on a.Id equals b.IdNV
                     join c in ihoadonchitietservice.GetAll() on b.id equals c.IdHoaDon
                     select new { a, b ,c});
            lb_sohoadon.Text = x.Select(x => x.c).Distinct().Sum( x => x.SoLuong).ToString();
            lb_sokh.Text = x.GroupBy(x => x.b).Count().ToString();
        }

        private void cbb_nv_TextChanged(object sender, EventArgs e)
        {
            _lstNhanVien = inhanvienservice.GetAll().Where(x => string.Concat(x.Ten, " ", x.TenDem, " ", x.Ho) == cbb_nv.Text).ToList();
            LoadThanhTichNhanVien();
        }
    }
}
