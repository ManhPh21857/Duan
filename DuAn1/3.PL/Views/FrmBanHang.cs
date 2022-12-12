using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.PL.ViewsFrm;
using _3.PL.ViewData;
using _2.BUS.IService;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _1.DAL.Models;
using _3.PL.ViewsFrm;
using _3.PL.Views;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace _3.Presentation
{
    public partial class FrmBanHang : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private readonly ISanPhamService _iQLSanPham;
        private readonly IChiTietSPService _iQLChiTietSanPham;
        private readonly IGioHangCTService _iQLGioHangChiTietServices;
        private readonly IHoaDonService _iQLHoaDonServices;
        private readonly IHoaDonCTService _iQLHoaDonChiTietServices;
        private readonly List<ChiTietSPView> _lstCTSanpham;
        public List<BangGioHangChiTiet> _lstGioHang;
        public BangGioHang _gioHang;
        public Guid _ctspID;
        public BangHoaDon _hdCho;
        FrmDangNhap dangnhap { get; set; }
        public FrmBanHang()
        {
            _lstCTSanpham = new List<ChiTietSPView>();
            InitializeComponent();
            _iQLSanPham = new SanPhamService();
            _iQLChiTietSanPham = new ChiTietSPService();
            _iQLHoaDonServices = new HoaDonService();
            _iQLHoaDonChiTietServices = new HoaDonCTService();
            _lstGioHang = new List<BangGioHangChiTiet>();
            loadSanPham();
            loadgiohang();
            loadHDcho();
            _gioHang = new BangGioHang()
            {
                Id = Guid.NewGuid()
            };
            DateTime da = new DateTime();
        }

        public void loadHDcho()
        {
            dtg_hoadoncho.Rows.Clear();
            dtg_hoadoncho.ColumnCount = 3;
            dtg_hoadoncho.Columns[0].Name = "ID";
            dtg_hoadoncho.Columns[0].Visible = false;
            dtg_hoadoncho.Columns[1].Name = "Mã";
            dtg_hoadoncho.Columns[2].Name = "Tình trạng";
            var lstHDcho = _iQLHoaDonServices.GetAll().Where(x => x.TinhTrang == 1).ToList();

            foreach (var item in _iQLHoaDonChiTietServices.GetAllView())
            {
                dtg_hoadoncho.Rows.Add(item.HoaDon.id, item.HoaDon.Ma, item.HoaDon.TinhTrang == 1?"Chưa Thanh Toán":"Đã Thanh Toán");
            }

        }

        private void loadgiohang()
        {
            dtg_giohang.Rows.Clear();

            dtg_giohang.ColumnCount = 9;
            dtg_giohang.Columns[0].Name = "Mã";
            dtg_giohang.Columns[1].Name = "Tên";
            dtg_giohang.Columns[2].Name = "Số Lượng";
            dtg_giohang.Columns[3].Name = "Đơn Giá";
            dtg_giohang.Columns[4].Name = "Tổng";
            dtg_giohang.Columns[5].Name = "Màu sắc";
            dtg_giohang.Columns[6].Name = "Dòng SP";
            dtg_giohang.Columns[7].Name = "NSX";
            dtg_giohang.Columns[8].Name = "ID ctsp";
            dtg_giohang.Columns[8].Visible = false;
            foreach (var item in _lstGioHang)
            {
                var ctsp = _iQLChiTietSanPham.GetAllView().FirstOrDefault(x => x.ChiTietSP.Id == item.IdCTSP);
                dtg_giohang.Rows.Add(
                    ctsp.SanPham.MaSP,
                    ctsp.SanPham.TenSP,
                    item.SoLuong,
                    item.DonGia,
                    item.SoLuong * item.DonGia,
                    ctsp.MauSac.TenMs,
                    ctsp.HangSP.TenHang,
                    ctsp.LoaiSP.TenLoai,
                    item.IdCTSP
                    );
            }
        }
        private void loadSanPham()
        {

            dtg_listsp.ColumnCount = 8;
            dtg_listsp.Columns[0].Name = "Id";
            dtg_listsp.Columns[0].Visible = false;
            dtg_listsp.Columns[1].Name = "Mã";
            dtg_listsp.Columns[2].Name = "Tên";
            dtg_listsp.Columns[3].Name = "Số Lượng tồn";
            dtg_listsp.Columns[4].Name = "Đơn giá";
            dtg_listsp.Columns[5].Name = "Hãng SP";
            dtg_listsp.Columns[6].Name = "Màu Sắc";
            dtg_listsp.Columns[7].Name = "Loại SP";
            dtg_listsp.Rows.Clear();
            var listsp = _iQLChiTietSanPham.GetAllView();
            listsp = listsp.OrderBy(p => p.SanPham.MaSP).ToList();
            var tim = _iQLChiTietSanPham.GetAll();
            if (tb_timkiem.Text != "")
            {
                tim = tim.Where(x => x.MaCTSP.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in listsp)
            {
                dtg_listsp.Rows.Add(item.ChiTietSP.Id, item.ChiTietSP.MaCTSP, item.SanPham.TenSP, item.ChiTietSP.Soluongton, item.ChiTietSP.GiaBan, item.HangSP.TenHang, item.MauSac.TenMs, item.LoaiSP.TenLoai);
            }
        }

        private void dtg_listsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_listsp.Rows[e.RowIndex];
                _ctspID = _iQLChiTietSanPham.GetAllView().FirstOrDefault(x => x.ChiTietSP.Id == Guid.Parse(r.Cells[0].Value.ToString())).ChiTietSP.Id;
                addGioHang(_ctspID);
            }
        }
        public void addGioHang(Guid id)
        {
            
            var sp = _iQLChiTietSanPham.GetAll().FirstOrDefault(x => x.Id == id);
            var data = _lstGioHang.FirstOrDefault(x => x.IdCTSP == id);
            if (data == null)
            {
                var soton = _iQLChiTietSanPham.GetAllView();
                BangGioHangChiTiet ghct = new BangGioHangChiTiet()
                {
                    IdGioHang = _gioHang.Id,
                    IdCTSP = id,
                    SoLuong = 1,
                    DonGia = sp.GiaBan,                    
                };
                _lstGioHang.Add(ghct);
            }
            else
            {
                data.SoLuong++;
            }
            loadgiohang();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            if (_lstGioHang.Any())
            {
                var hoaDon = new BangHoaDon()
                {
                    id = Guid.NewGuid(),
                    Ma = (_iQLHoaDonServices.GetAll().Count + "HD0" +1).ToString(),     
                    TinhTrang = 1

                };
                _iQLHoaDonServices.Add(hoaDon);
                var km = new BangKhuyenMai();
                
                foreach (var item in _lstGioHang)
                {
                    var hdct = new BangHoaDonCT()
                    {
                        IdHoaDon = hoaDon.id,
                        IDCTSP = item.IdCTSP,
                        IDKM = km.Id,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia
                    };
                    _iQLHoaDonChiTietServices.Add(hdct);
                    var sp = _iQLChiTietSanPham.GetAll().FirstOrDefault(x => x.Id == item.Id);
                    sp.Soluongton -= item.SoLuong;
                    //_iQLChiTietSanPham.updateChiTietSp(sp);
                }
                MessageBox.Show("Tao hoa don thanh cong");
                _lstGioHang = new List<BangGioHangChiTiet>();
                loadgiohang();
                loadSanPham();
                loadHDcho();
            }
            else
            {
                MessageBox.Show("Chua co sp trong gio hang");
            }
        }

        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            _lstGioHang = new List<BangGioHangChiTiet>();
            loadgiohang();
        }

        private void btn_xoáp_Click(object sender, EventArgs e)
        {
            var x = _lstGioHang.FirstOrDefault(x => x.IdCTSP == _ctspID);
            _lstGioHang.Remove(x);
            loadgiohang();
        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
            _ctspID = Guid.Parse(r.Cells[8].Value.ToString());
        }

        private void dtg_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_hoadoncho.Rows[e.RowIndex];
                _hdCho = _iQLHoaDonServices.GetAll().FirstOrDefault(x=>x.id== Guid.Parse(r.Cells[0].Value.ToString()));
                lb_mahd.Text = r.Cells[1].Value.ToString();
                lb_tongtien.Text = _iQLHoaDonChiTietServices.GetAll().Where(x=>x.IdHoaDon == _hdCho.id).Sum(x=>x.DonGia*x.SoLuong).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var km = new BangKhuyenMai();

            if (int.TryParse(tb_tienkhachdua.Text,out int x))
            {
                lb_tienthua.Text = (decimal.Parse(tb_tienkhachdua.Text) - decimal.Parse(lb_tongtien.Text)).ToString();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (int.Parse(lb_tienthua.Text) <0)
            {
                MessageBox.Show("Thieu tien");
            }else if(!int.TryParse(tb_tienkhachdua.Text, out int x))
            {
                MessageBox.Show("Tien khach dua ko hop le");
            }
            else
            {
                _hdCho.TinhTrang = 2;
                _iQLHoaDonServices.Update(_hdCho);
                loadHDcho();
                MessageBox.Show("Thanh toan thanh cong");
            }
        }

        private void lb_tienthua_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_timkiem.Text = "ctsp01";
            loadSanPham();
        }

        private void tbn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadSanPham();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmChiTietSp ctsp = new FrmChiTietSp();
            ctsp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai1 fm = new FrmKhuyenMai1();
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_tongtien_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe();
            tk.ShowDialog();
        }
    }
}
