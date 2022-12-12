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
    public partial class FrmHangSp : Form
    {
        public IHangSPService _hangSpService = new HangSPService();
        public BangHangSanPham _HSP = new BangHangSanPham();
        List<BangHangSanPham> _hangSpList = new List<BangHangSanPham>();
        public FrmHangSp()
        {
            InitializeComponent();
            LoadToData();
        }
        public void LoadToData()
        {
            dtg_show.ColumnCount = 4;
            int stt = 1;
            dtg_show.Columns[0].Name = "id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Tên Hãng";
            dtg_show.Columns[3].Name = "Mã Hãng";
            dtg_show.Rows.Clear();
            var lst = _hangSpService.GetAll();

            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.IdHang, stt++, item.TenHang, item.MaHang);
            }
        }
        public void ResetFrm()
        {
            LoadToData();
            tb_tenhang.Text = "";
            tb_mahang.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_mahang.Text == "")
            {
                MessageBox.Show("Vui long nhap ma khach hang");
            }else if (_hangSpService.GetAll().Any(p => p.MaHang == tb_mahang.Text))
            {
                MessageBox.Show("Ma khach hang da ton tai");
            }
            else
            {
                var item = new BangHangSanPham()
                {

                    IdHang = new Guid(),
                    MaHang = tb_mahang.Text,
                    TenHang = tb_tenhang.Text,
                };
                _hangSpService.Add(item);
                MessageBox.Show("Thêm thành công");
                LoadToData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_HSP == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                _hangSpService.Delete(_HSP);
                MessageBox.Show("Xóa Loại thành công");
                ResetFrm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_mahang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyễn mãi");
            }
            else
            {
                if (_HSP.MaHang == tb_mahang.Text || (_HSP.MaHang != tb_mahang.Text && _hangSpService.GetAll().FirstOrDefault(x => x.MaHang == tb_mahang.Text) == null))
                {
                    _HSP.MaHang = tb_mahang.Text;
                    _HSP.TenHang = tb_tenhang.Text;
                    _hangSpService.Update(_HSP);
                    MessageBox.Show("Sửa Khuyến Mại thành công");
                    LoadToData();
                }
                else
                {
                    MessageBox.Show("Mã khuyến mại đã tồn tại");
                }
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dt = dtg_show.Rows[e.RowIndex];
                _HSP = _hangSpService.GetAll().FirstOrDefault(p => p.IdHang == Guid.Parse(dt.Cells[0].Value.ToString()));
                tb_mahang.Text = dt.Cells[3].Value.ToString();
                tb_tenhang.Text = dt.Cells[2].Value.ToString();
            }
        }
    }
}
