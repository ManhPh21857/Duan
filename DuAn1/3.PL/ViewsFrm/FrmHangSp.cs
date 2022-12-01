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
    }
}
