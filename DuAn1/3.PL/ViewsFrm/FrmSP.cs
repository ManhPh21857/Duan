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
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.ViewModels;
namespace _3.PL.ViewsFrm
{
    public partial class FrmSP : Form
    {
        private ISanPhamService _iSanPhamService;
        private BangSanPham _SP;
        public FrmSP()
        {
            _iSanPhamService = new SanPhamService();
            _SP = new BangSanPham();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            digrav_show.ColumnCount = 4;
            int stt = 1;
            digrav_show.Columns[0].Name = "Id";
            digrav_show.Columns[0].Visible = false;
            digrav_show.Columns[1].Name = "STT";
            digrav_show.Columns[2].Name = "Mã";
            digrav_show.Columns[3].Name = "Tên SP";
            digrav_show.Rows.Clear();
            var timkiem = _iSanPhamService.GetAll();
            if (txt_TimKiem.Text != "")
            {
                timkiem = timkiem.Where(p => p.TenSP.ToLower().Contains(txt_TimKiem.Text) || p.MaSP.ToLower().Contains(txt_TimKiem.Text)).ToList();
            }
            foreach (var item in _iSanPhamService.GetAll())
            {
                digrav_show.Rows.Add(item.Id, stt++, item.MaSP, item.TenSP);
            }
        }

        private void digrav_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dt = digrav_show.Rows[e.RowIndex];
                _SP = _iSanPhamService.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                txt_Ma.Text = dt.Cells[2].Value.ToString();
                txt_TenSP.Text = dt.Cells[3].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == null)
            {
                MessageBox.Show("vui lòng nhập mã sp");
            }
            else
            {

                var add = new BangSanPham()
                {
                    Id = new Guid(),
                    MaSP = txt_Ma.Text,
                    TenSP = txt_TenSP.Text,
                };
                _iSanPhamService.Add(add);
                MessageBox.Show("Thêm thành công");
                LoadData();

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu sắc");
            }
            else
            {
                if (_SP.MaSP == txt_Ma.Text || (_SP.MaSP != txt_Ma.Text && _iSanPhamService.GetAll().FirstOrDefault(x => x.MaSP == txt_Ma.Text) == null))
                {
                    _SP.MaSP = txt_Ma.Text;
                    _SP.TenSP = txt_TenSP.Text;
                    _iSanPhamService.Update(_SP);
                    MessageBox.Show("Sửa màu sắc thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Mã Loại đã tồn tại");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            _iSanPhamService.Delete(_SP);
            MessageBox.Show("Xóa thành công");
            LoadData();
        }
    }
}
