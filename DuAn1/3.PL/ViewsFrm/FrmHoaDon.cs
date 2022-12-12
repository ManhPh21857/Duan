using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _1.DAL.Models;
using _2.BUS.IService;

namespace _3.PL.ViewData
{
    public partial class FrmHoaDon : Form
    {
        public IHoaDonService _hoaDonService = new HoaDonService();
        public BangHoaDon _HD = new BangHoaDon();
        public INhanVienService _nhanVienService = new NhanVienService();
        public IKhachHangService _khachHangService = new KhachHangService();
        List<BangHoaDon> _hoaDonList = new List<BangHoaDon>();
        public FrmHoaDon()
        {
            InitializeComponent();
            foreach(var nhanvien in _nhanVienService.GetAll())
            {
                cbb_nhanvien.Items.Add(nhanvien.Ma);
            }
            foreach (var khachhang in _khachHangService.GetAll())
            {
                cbb_khachhang.Items.Add(khachhang.Ma);
            }
            LoadData();
        }
        public void LoadData()
        {
            dtg_show.ColumnCount = 13;
            int stt = 1;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã hóa đơn";
            dtg_show.Columns[3].Name = "Nhân viên";
            dtg_show.Columns[4].Name = "Khách hàng";
            dtg_show.Columns[5].Name = "Tên người nhận";
            dtg_show.Columns[6].Name = "Ngày Tạo";
            dtg_show.Columns[7].Name = "Ngày Thanh Toán";
            dtg_show.Columns[8].Name = "Ngày Ship";
            dtg_show.Columns[9].Name = "Ngày Nhận";
            dtg_show.Columns[10].Name = "Tình Trạng";
            dtg_show.Columns[11].Name = "SDT";
            dtg_show.Columns[12].Name = "Địa chỉ";
            dtg_show.Rows.Clear();
            var lstHD = _hoaDonService.GetAllView();//_IChucVuService.GetAll().Where(p => p.Id == nhanvien.IdCV).Select(p => p.TenCV).FirstOrDefault(), 
            foreach (var item in lstHD)
            {
                dtg_show.Rows.Add(item.HoaDon.id, stt++, item.HoaDon.Ma, item.NhanVien.Ma, item.KhachHang.Ma, item.HoaDon.TenNguoiNhan, item.HoaDon.NgayTao, item.HoaDon.NgayThanhToan, item.HoaDon.NgayShip, item.HoaDon.NgayNhan, item.HoaDon.TinhTrang == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán", item.HoaDon.SDT, item.HoaDon.DiaChi);
            }
        }
        public void ResetFrm()
        {
            LoadData();
            tb_ma.Text = "";
            cbb_nhanvien.Text = "";
            cbb_khachhang.Text = "";
            tb_tenngnhan.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            rb_dathanhtoan.Checked = false;
            rb_chuathanhtoan.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            else if (_hoaDonService.GetAll().Any(p => p.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã hóa đơn tồn tại");
            }
            else
            {
                var item = new BangHoaDon()
                {

                    id = new Guid(),
                    IdNV = _nhanVienService.GetAll().FirstOrDefault(p=>p.Ma == cbb_nhanvien.Text).Id,
                    IdKH = _khachHangService.GetAll().FirstOrDefault(p=>p.Ma == cbb_khachhang.Text).Id,
                    Ma = tb_ma.Text,
                    TenNguoiNhan = tb_tenngnhan.Text,
                    NgayTao = Convert.ToDateTime(dtp_ngaytao.Text),
                    NgayNhan = Convert.ToDateTime(dtp_ngaynhan.Text),
                    NgayShip = Convert.ToDateTime(dtp_ngayship.Text),
                    NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Text),
                    SDT = tb_sdt.Text,
                    DiaChi = tb_diachi.Text,
                    TinhTrang = rb_dathanhtoan.Checked ? 0 : 1,
                };
                _hoaDonService.Add(item);
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _HD = _hoaDonService.GetAll().FirstOrDefault(x => x.id == Guid.Parse(r.Cells[1].Value.ToString()));
                tb_ma.Text = r.Cells[2].Value.ToString();
                cbb_nhanvien.Text = r.Cells[3].Value.ToString();
                cbb_khachhang.Text = r.Cells[4].Value.ToString();
                tb_tenngnhan.Text = r.Cells[5].Value.ToString();
                tb_sdt.Text = r.Cells[6].Value.ToString();
                tb_diachi.Text = r.Cells[7].Value.ToString();
                rb_chuathanhtoan.Text = r.Cells[10].Value.ToString();
                rb_dathanhtoan.Text = r.Cells[10].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã");
            }
            else
            {
                var item = new BangHoaDon()
                {
                    Ma = tb_ma.Text,
                    TenNguoiNhan = tb_tenngnhan.Text,
                    SDT = tb_sdt.Text,
                    DiaChi = tb_diachi.Text,
                    TinhTrang = rb_dathanhtoan.Checked ? 0 :1,
                };
                _hoaDonService.Update(item);
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetFrm();
        }
    }
}
