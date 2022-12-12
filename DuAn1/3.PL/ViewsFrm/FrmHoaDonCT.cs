using _2.BUS.IService;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.IServices;

namespace _3.PL.ViewData
{
    public partial class FrmHoaDonCT : Form
    {
        public IHoaDonCTService _hoaDonCTService = new HoaDonCTService();
        public IChiTietSPService _CTSP = new ChiTietSPService();
        public IKhuyenMaiService _KM = new KhuyenMaiService();
        public IHoaDonService _HD = new HoaDonService();
        public BangHoaDonCT _HDCT = new BangHoaDonCT();
        List<BangHoaDonCT> _hoaDonCTList = new List<BangHoaDonCT>();
        public FrmHoaDonCT()
        {
            InitializeComponent();
            LoadData();
            foreach(var item in _HD.GetAll())
            {
                cbb_hoadon.Items.Add(item.Ma);
            }
            foreach (var item in _KM.GetAll())
            {
                cbb_khuyenmai.Items.Add(item.MaKM);
            }
            
            foreach (var item in _CTSP.GetAll())
            {
                cbb_ctsp.Items.Add(item.MaCTSP);
            }
        }  
        public void LoadData()
        {
            dtg_show.ColumnCount = 8;
            int stt = 1;         
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã Hóa Đơn";
            dtg_show.Columns[3].Name = "Mã Khuyến Mại";
            dtg_show.Columns[4].Name = "Mã CTSP";
            dtg_show.Columns[5].Name = "Số Lượng";
            dtg_show.Columns[6].Name = "Mô Tả";
            dtg_show.Columns[7].Name = "Đơn Giá";
            dtg_show.Rows.Clear();
            var lstHDCT = _hoaDonCTService.GetAllView();
            foreach (var item in lstHDCT)
            {
                dtg_show.Rows.Add(stt, item.HoaDon.Ma, item.KhuyenMai.MaKM, item.CTSanPham.MaCTSP,item.HoaDonCT.Mota, item.HoaDonCT.DonGia);
            }
        }
        public void TongGia()
        {
            foreach(var item in _hoaDonCTService.GetAllView())
            {
                
            }
        }
        public void ResetFrm()
        {
            LoadData();
            tb_soluong.Text = "";
            tb_mota.Text = "";
            tb_dongia.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var item = new BangHoaDonCT()
            {
                IDCTSP = new Guid(),
                IdHoaDon = new Guid(),
                IDKM = new Guid(),
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                Mota = tb_mota.Text,
                DonGia = Convert.ToInt32(tb_dongia.Text)
            };
            _hoaDonCTService.Add(item);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var item = new BangHoaDonCT()
            {
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                Mota = tb_mota.Text,
                DonGia = Convert.ToInt32(tb_dongia.Text)
            };
            _hoaDonCTService.Update(item);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetFrm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                cbb_hoadon.Text = r.Cells[2].Value.ToString();
                cbb_khuyenmai.Text = r.Cells[3].Value.ToString();
                cbb_ctsp.Text = r.Cells[4].Value.ToString();
                tb_soluong.Text = r.Cells[5].Value.ToString();
                tb_mota.Text = r.Cells[6].Value.ToString();
                tb_dongia.Text = r.Cells[7].Value.ToString();
            }
        }
    }
}
