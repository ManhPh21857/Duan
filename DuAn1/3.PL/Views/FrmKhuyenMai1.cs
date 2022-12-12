using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.IServices;
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
using _3.Presentation;
namespace _3.PL.Views
{
    public partial class FrmKhuyenMai1 : Form
    {
        public IKhuyenMaiService _iKM = new KhuyenMaiService();
        public IHoaDonService _iHoaDon = new HoaDonService();
        public BangKhuyenMai _KM = new BangKhuyenMai();
        public List<BangKhuyenMai> _lstKM = new List<BangKhuyenMai>();
        FrmBanHang banhang = new FrmBanHang();
        public FrmKhuyenMai1()
        {
            InitializeComponent();
            LoadtoKhuyenMai();
     
        }
        
        public void LoadtoKhuyenMai()
        {
            int stt = 1;
            dtg_Showkhuyenmai.ColumnCount = 7;
            dtg_Showkhuyenmai.Columns[0].Name = "Id";
            dtg_Showkhuyenmai.Columns[0].Visible = false;
            dtg_Showkhuyenmai.Columns[1].Name = "Stt";
            dtg_Showkhuyenmai.Columns[2].Name = "Mã Khuyến Mại";
            dtg_Showkhuyenmai.Columns[3].Name = "Ngày bắt đầu";
            dtg_Showkhuyenmai.Columns[4].Name = "Ngày kêt thúc";
            dtg_Showkhuyenmai.Columns[5].Name = "Só tiền giảm";
            dtg_Showkhuyenmai.Columns[6].Name = "Mô tả";
            dtg_Showkhuyenmai.Rows.Clear();
            foreach (var item in _iKM.GetAll())
            {
                dtg_Showkhuyenmai.Rows.Add(item.Id, stt++, item.MaKM, item.NgayBatDau, item.NgyaKetThuc, item.GiamGia, item.MotaKM);
            }
        }
        public void ResetForm()
        {
            _KM = null;
            LoadtoKhuyenMai();
            tb_ma.Text = "";
            tb_giamgia.Text = "";
            dtp_ngbd.Value = DateTime.Now;
            dtp_ngbd.Value = DateTime.Now;
            tb_mota.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khuyễn mại");
            }
            else
            {
                var add = new BangKhuyenMai()
                {
                    Id = new Guid(),
                    MaKM = tb_ma.Text,
                    GiamGia = Convert.ToInt32(tb_giamgia.Text),
                    NgayBatDau = Convert.ToDateTime(dtp_ngbd.Text),
                    NgyaKetThuc = Convert.ToDateTime(dtp_ngkk.Text),
                    MotaKM = tb_mota.Text,
                };
                _iKM.Add(add);
                MessageBox.Show("Thêm thành công");
                LoadtoKhuyenMai();
            }
        }

        private void dtg_Showkhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dt = dtg_Showkhuyenmai.Rows[e.RowIndex];
                _KM = _iKM.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                tb_ma.Text = _KM.MaKM;
                _KM.NgayBatDau = Convert.ToDateTime(dtp_ngbd.Text);
                _KM.NgyaKetThuc = Convert.ToDateTime(dtp_ngkk.Text);
                _KM.GiamGia = Convert.ToInt32(tb_giamgia.Text);
                tb_mota.Text = _KM.MotaKM;
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyễn mãi");
            }
            else
            {
                if (_KM.MaKM == tb_ma.Text || (_KM.MaKM != tb_ma.Text && _iKM.GetAll().FirstOrDefault(x => x.MaKM == tb_ma.Text) == null))
                {
                    _KM.MaKM = tb_ma.Text;
                    _KM.NgayBatDau = Convert.ToDateTime(dtp_ngbd.Text);
                    _KM.NgyaKetThuc = Convert.ToDateTime(dtp_ngkk.Text);
                    _KM.GiamGia = Convert.ToInt16(tb_giamgia.Text);
                    _KM.MotaKM = tb_mota.Text;
                    _iKM.Update(_KM);
                    MessageBox.Show("Sửa Khuyến Mại thành công");
                    LoadtoKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Mã khuyến mại đã tồn tại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_KM == null)
            {
                MessageBox.Show("Vui lòng chọn mã");
            }
            else
            {
                _iKM.Delete(_KM);
                MessageBox.Show("Xóa thành công");
                LoadtoKhuyenMai();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {

        }

        private void FrmKhuyenMai1_Load(object sender, EventArgs e)
        {

        }
    }
}
