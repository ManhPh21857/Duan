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
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _1.DAL.Models;
using _3.Presentation;
namespace _3.PL.Views
{
    // Id { get; set; }
    // IdSp { get; set; }
    // IdLoai { get; set; }
    // IdMauSac { get; set; }
    // IdHang { get; set; }
    //Soluongton { get; set; }
    //Mota { get; set; }
    //GiaNhap { get; set; }
    //GiaBan { get; set; }
    //Size { get; set; }
    public partial class FrmChiTietSp : Form
    {
        private IChiTietSPService _iCTSP;
        List<ChiTietSPView> lst = new List<ChiTietSPView>();
        List<BangChiTietSanPham> _lstCTSP;
        public IMauSacService _MauSac;
        public IHangSPService _HangSP;
        public ISanPhamService _SanPham;
        public ILoaiService _LoaiSP;
        public BangChiTietSanPham _ChiTietSP;
        FrmBanHang bnahang { get; set; }
        public FrmChiTietSp()
        {
            _LoaiSP = new LoaiSPService();
            _SanPham = new SanPhamService();
            _HangSP = new HangSPService();
            _MauSac = new MauSacService();
            _iCTSP = new ChiTietSPService();
            _lstCTSP = new List<BangChiTietSanPham>();
            InitializeComponent();
            LoadCombobox();
            LoadToData();
        }
        public void LoadCombobox()
        {
            foreach (var item in _MauSac.GetAll())
            {
                cbb_mausac.Items.Add(item.TenMs);
            }
            foreach (var item in _HangSP.GetAll())
            {
                cbb_hangsp.Items.Add(item.TenHang);
            }
            foreach (var item in _SanPham.GetAll())
            {
                cbb_tensp.Items.Add(item.TenSP);
            }
            foreach (var item in _LoaiSP.GetAll())
            {
                cbb_loaisp.Items.Add(item.TenLoai);
            }
        }
        public void LoadToData()
        {
            dtg_show.ColumnCount = 12;
            int stt = 1;
            dtg_show.Columns[0].Name = "id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã SP";
            dtg_show.Columns[3].Name = "Tên SP";
            dtg_show.Columns[4].Name = "Loại SP";
            dtg_show.Columns[5].Name = "Màu Sắc";
            dtg_show.Columns[6].Name = "Hãng giày";
            dtg_show.Columns[7].Name = "Số lượng tồn";
            dtg_show.Columns[8].Name = "Mô tả";
            dtg_show.Columns[9].Name = "Giá nhập";
            dtg_show.Columns[10].Name = "Giá bán";
            dtg_show.Columns[11].Name = "Size";
            dtg_show.Rows.Clear();
            var lst = _iCTSP.GetAllView();
            
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.ChiTietSP.Id, stt++, item.ChiTietSP.MaCTSP, item.SanPham.TenSP,item.LoaiSP.TenLoai,item.MauSac.TenMs,item.HangSP.TenHang , item.ChiTietSP.Soluongton,item.ChiTietSP.Mota ,item.ChiTietSP.GiaNhap, item.ChiTietSP.GiaBan, item.ChiTietSP.Size);
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            
            


            if (cbb_tensp.Text == "")
            {
                MessageBox.Show("Vui chọn tên sản phẩm");
            }else if(cbb_loaisp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại sp");
            }else if(cbb_hangsp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Hãng sp");
            }else if(cbb_mausac.Text == "")
            {
                MessageBox.Show("Vui lòng chọn màu sp");
            }
            else
            {
                var chitietSP = new BangChiTietSanPham()
                {
                    Id = new Guid(),
                    Mota = tb_mota.Text,
                    MaCTSP = tb_ma.Text,
                    IdMauSac = _MauSac.GetAll().FirstOrDefault(x => x.TenMs == cbb_mausac.Text).Id,
                    IdHang = _HangSP.GetAll().FirstOrDefault(x => x.TenHang == cbb_hangsp.Text).IdHang,
                    IdLoai = _LoaiSP.GetAll().FirstOrDefault(x => x.TenLoai == cbb_loaisp.Text).Id,
                    IdSp = _SanPham.GetAll().FirstOrDefault(x => x.TenSP == cbb_tensp.Text).Id,
                    Soluongton = Convert.ToInt32(tb_soluongton.Text),
                    GiaBan = Convert.ToDecimal(tb_giaban.Text),
                    GiaNhap = Convert.ToDecimal(tb_gianhap.Text),
                    Size = Convert.ToInt32(tb_size.Text),
                };
                _iCTSP.Add(chitietSP);
                MessageBox.Show("Thêm Sản Phẩm thành công");
                LoadToData();
            }

        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dt = dtg_show.Rows[e.RowIndex];
                _ChiTietSP = _iCTSP.GetAll().FirstOrDefault(p => p.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                cbb_tensp.Text = _SanPham.GetAll().FirstOrDefault(p => p.Id ==_ChiTietSP.IdSp).TenSP;
                cbb_hangsp.Text = _HangSP.GetAll().FirstOrDefault(p => p.IdHang == _ChiTietSP.IdHang).TenHang;
                cbb_loaisp.Text = _LoaiSP.GetAll().FirstOrDefault(p => p.Id == _ChiTietSP.IdLoai).TenLoai;
                cbb_mausac.Text = _MauSac.GetAll().FirstOrDefault(p => p.Id == _ChiTietSP.IdMauSac).TenMs;
                tb_ma.Text = dt.Cells[2].Value.ToString();
                tb_soluongton.Text =dt.Cells[7].Value.ToString();
                tb_mota.Text = dt.Cells[8].Value.ToString();
                tb_gianhap.Text = dt.Cells[9].Value.ToString();
                tb_giaban.Text = dt.Cells[10].Value.ToString();
                tb_size.Text = dt.Cells[11].Value.ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Mã");
            }
            else
            {
                if (_ChiTietSP.MaCTSP == tb_ma.Text || (_ChiTietSP.MaCTSP != tb_ma.Text && _iCTSP.GetAll().FirstOrDefault(x => x.MaCTSP == tb_ma.Text) == null))
                {
                    _ChiTietSP.Mota = tb_mota.Text;
                    _ChiTietSP.IdMauSac = _MauSac.GetAll().FirstOrDefault(p => p.TenMs == cbb_mausac.Text).Id;
                    _ChiTietSP.IdHang = _HangSP.GetAll().FirstOrDefault(p => p.TenHang == cbb_hangsp.Text).IdHang;
                    _ChiTietSP.IdLoai = _LoaiSP.GetAll().FirstOrDefault(p => p.TenLoai == cbb_loaisp.Text).Id;
                    _ChiTietSP.IdSp = _SanPham.GetAll().FirstOrDefault(p => p.TenSP == cbb_tensp.Text).Id;
                    _ChiTietSP.Soluongton = Convert.ToInt32(tb_soluongton.Text);
                    _ChiTietSP.GiaNhap = Convert.ToDecimal(tb_gianhap.Text);
                    _ChiTietSP.GiaBan = Convert.ToDecimal(tb_giaban.Text);
                    _ChiTietSP.Size = Convert.ToInt32(tb_size.Text);
                    _ChiTietSP.MaCTSP = tb_ma.Text;
                    _iCTSP.Update(_ChiTietSP);
                    MessageBox.Show("Sửa Chi Tiet SP thành công");
                    LoadToData();
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_ChiTietSP == null)
            {
                MessageBox.Show("Vui lòng chọn Sản Phẩm");
            }
            else
            {
                _iCTSP.Delete(_ChiTietSP);
                MessageBox.Show("Xóa Sản Phẩm thành công");
                LoadToData();
            }
        }

        private void FrmChiTietSp_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai1 km = new FrmKhuyenMai1();
            km.ShowDialog();
        }
    }
}
