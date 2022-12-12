using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
namespace _3.PL.ViewsFrm
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService _khachHangService = new KhachHangService();
        private BangKhachHang _KhachHang = new BangKhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        public void LoadTodata()
        {
            int stt = 1;
            dgria_show.ColumnCount = 9;
            dgria_show.Columns[0].Name = "Id";
            dgria_show.Columns[0].Visible = false;
            dgria_show.Columns[1].Name = "Stt";
            dgria_show.Columns[2].Name = "Ma";
            dgria_show.Columns[3].Name = "Họ Và Tên";
            dgria_show.Columns[4].Name = "Ngày Sinh";
            dgria_show.Columns[5].Name = "Gioi Tính";
            dgria_show.Columns[6].Name = "SDT";
            dgria_show.Columns[7].Name = "Địa Chỉ";
            dgria_show.Columns[8].Name = "Mật Khẩu";
            dgria_show.Rows.Clear();
            foreach (var item in _khachHangService.GetAll())
            {
                dgria_show.Rows.Add(item.Id, stt++, item.Ma, string.Concat(item.Ho, " ", item.TenDem, " ", item.Ten), item.NgaySinh, item.GioiTinh, item.SDT, item.DiaChi, item.MatKhau);
            }
        }
        public void ResetFrm()
        {
            LoadTodata();
            txt_Ma.Text = "";
            txt_Ho.Text = "";
            txt_TenDem.Text = "";
            txt_Ten.Text = "";
            dtk_ngay_sinh.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_GioiTinh.Text = "";
            txt_MatKhau.Text = "";
        }

        private void dgria_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dt = dgria_show.Rows[e.RowIndex];
                _KhachHang = _khachHangService.GetAll().FirstOrDefault(p => p.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                txt_Ma.Text = dt.Cells[2].Value.ToString();
                txt_Ho.Text = dt.Cells[3].Value.ToString();
                txt_TenDem.Text = dt.Cells[3].Value.ToString();
                txt_Ten.Text = dt.Cells[3].Value.ToString();
                dtk_ngay_sinh.Text = dt.Cells[4].Value.ToString();
                txt_GioiTinh.Text = dt.Cells[5].Value.ToString();
                txt_SDT.Text = dt.Cells[6].Value.ToString();
                txt_DiaChi.Text = dt.Cells[7].Value.ToString();
                txt_MatKhau.Text = dt.Cells[8].Value.ToString();

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã kh");
            }
            else if (_khachHangService.GetAll().Any(x => x.Ma == txt_Ma.Text))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại");
            }
            else
            {
                var ms = new BangKhachHang()
                {
                    Id = new Guid(),
                    Ma = txt_Ma.Text,
                    Ho = txt_Ho.Text,
                    TenDem = txt_TenDem.Text,
                    Ten = txt_Ten.Text,
                    NgaySinh = Convert.ToDateTime(dtk_ngay_sinh.Text),
                    GioiTinh = txt_GioiTinh.Text,
                    SDT = txt_SDT.Text,
                    DiaChi = txt_DiaChi.Text,
                    MatKhau = txt_MatKhau.Text,
                };
                _khachHangService.Add(ms);
                MessageBox.Show("Thêm khách hàng thành công");
                ResetFrm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
            else if (_KhachHang == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
            else
            {
                if (_KhachHang.Ma == txt_Ma.Text || (_KhachHang.Ma != txt_Ma.Text && _khachHangService.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text) == null))
                {
                    _KhachHang.Ma = txt_Ma.Text;
                    _KhachHang.Ho = txt_Ho.Text;
                    _KhachHang.TenDem = txt_TenDem.Text;
                    _KhachHang.Ten = txt_Ten.Text;
                    _KhachHang.NgaySinh = Convert.ToDateTime(dtk_ngay_sinh.Text);
                    _KhachHang.GioiTinh = txt_GioiTinh.Text;
                    _KhachHang.SDT = txt_SDT.Text;
                    _KhachHang.DiaChi = txt_DiaChi.Text;
                    _khachHangService.Update(_KhachHang);
                    MessageBox.Show("Sửa khach hang thành công");
                    ResetFrm();
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_KhachHang == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
            else
            {
                _khachHangService.Delete(_KhachHang);
                MessageBox.Show("Xóa Khách hàng thành công");
                ResetFrm();
            }
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetFrm();
        }

        private void txt_TenDem_Click(object sender, EventArgs e)
        {

        }
    }
}
