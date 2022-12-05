using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.IServices;
using _2.BUS.Service;
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

namespace _3.PL.Views
{
    public partial class FrmGioHang : Form
    {
        public IGioHangService _iGioHangService = new GioHangService();
        public INhanVienService _iNhanVienService = new NhanVienService();
        public IKhachHangService _iKhachHangService = new KhachHangService();
        
        public BangGioHang _GH = new BangGioHang();
        List<BangGioHang> _lstGioHang = new List<BangGioHang>();
        public FrmGioHang()
        {
            InitializeComponent();
            LoadtoData();
        }
        public void LoadtoData()
        {
            dtg_Show.ColumnCount = 8;
            int stt = 1;
            dtg_Show.Columns[0].Name = "Id";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Mã";
            dtg_Show.Columns[2].Name = "Ngày tạo";
            dtg_Show.Columns[3].Name = "Ngày thanh toán";
            dtg_Show.Columns[4].Name = "Người nhận";
            dtg_Show.Columns[5].Name = "Địa chỉ";
            dtg_Show.Columns[6].Name = "SDT";
            dtg_Show.Columns[7].Name = "Tình trạng";
           
            dtg_Show.Rows.Clear();
            var lst = _iGioHangService.GetAll();
            foreach(var item in lst)
            {
                dtg_Show.Rows.Add(item.Ma, stt++, item.NgayTao.ToString(), item.NgayThanhToan.ToString(), item.NguoiNhan, item.DiaChi, item.SDT, item.TinhTrang == 1 ? "Thanh toán": "Chưa thanh toán") ;
            }
        }
        public void resetForm()
        {
            LoadtoData();
            _GH = null;
            tb_ma.Text = "";
            tb_ngnhan.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            dtp_ngtao.Value = DateTime.Now;
            dtp_ngtt.Value = DateTime.Now;
            cb_tt.Checked = true;
            cb_ctt.Checked = false;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã");
            }
            else if (_iGioHangService.GetAll().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else if (!cb_tt.Checked && !cb_ctt.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                var gh = new BangGioHang()
                {
                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    NgayTao = dtp_ngtao.Value,
                    NgayThanhToan = dtp_ngtao.Value,
                    NguoiNhan = tb_ngnhan.Text,                                 
                    DiaChi = tb_diachi.Text,
                    SDT = tb_sdt.Text,                                                     
                    TinhTrang = cb_tt.Checked ? 1 : 0,
                };
                _iGioHangService.Add(gh);
                MessageBox.Show("Thêm thành công");
                resetForm();
            }
        }       
        private void cb_ctt_Click(object sender, EventArgs e)
        {
            if (cb_ctt.Checked)
            {
                cb_ctt.Checked = false;
            }
            cb_ctt.Checked = true;
        }

        private void cb_tt_Click(object sender, EventArgs e)
        {
            if (cb_tt.Checked)
            {
                cb_tt.Checked = false;
            }
            cb_tt.Checked = true;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_GH == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            else
            {
                _iGioHangService.Delete(_GH);
                MessageBox.Show("Xóa nhân viên thành công");
                resetForm();
            }
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _GH= _iGioHangService.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _GH.Ma;
                dtp_ngtao.Text = r.Cells[1].Value.ToString();
                dtp_ngtt.Text = r.Cells[2].Value.ToString();
                tb_ngnhan.Text = _GH.NguoiNhan;
                tb_diachi.Text = _GH.DiaChi;
                tb_sdt.Text = _GH.SDT;
                cb_tt.Checked = _GH.TinhTrang == 1;
                cb_ctt.Checked = _GH.TinhTrang == 0;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã");
            }
            else if (_iGioHangService.GetAll().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else if (!cb_tt.Checked && !cb_ctt.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                if (_GH.Ma == tb_ma.Text || (_GH.Ma != tb_ma.Text && _iGioHangService.GetAll().FirstOrDefault(x => x.Ma == tb_ma.Text) == null))
                {
                    _GH.Ma = tb_ma.Text;
                    _GH.NguoiNhan = tb_ngnhan.Text;
                    _GH.NgayTao = dtp_ngtao.Value;
                    _GH.NgayThanhToan = dtp_ngtt.Value;
                    _GH.DiaChi = tb_diachi.Text;
                    _GH.SDT = tb_sdt.Text;
                    _GH.TinhTrang = cb_tt.Checked ? 1 : 0;                   
                    _iGioHangService.Update(_GH);
                    MessageBox.Show("Sửa thành công");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
            }
        }
    }
}
