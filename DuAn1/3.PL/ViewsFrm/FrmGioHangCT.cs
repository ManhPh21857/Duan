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
    public partial class FrmGioHangCT : Form
    {
        public IGioHangCTService _iGioHangCTService = new GioHangCTService();
        public IGioHangService _iGioHangService = new GioHangService();
        public IChiTietSPService _iChiTietSPService = new ChiTietSPService();
        public BangGioHangChiTiet _GHCT = new BangGioHangChiTiet();
        List<BangGioHangChiTiet> _lstGHCT = new List<BangGioHangChiTiet>();
        public FrmGioHangCT()
        {
            InitializeComponent();
            LoadtoData();
        }
        public void LoadtoData()
        {
            dtg_Show.ColumnCount = 3;
            int stt = 1;
            dtg_Show.Columns[0].Name = "ID";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Đơn giá";
            dtg_Show.Columns[2].Name = "Số lượng";
            dtg_Show.Rows.Clear();
            var lst = _iGioHangCTService.GetAll();
            foreach (var item in lst)
            {
                dtg_Show.Rows.Add(item.Id, stt++, item.DonGia, item.SoLuong);
            }
        }
        public void ResetForm()
        {
            _GHCT = null;
            LoadtoData();
            tb_dongia.Text = "";
            tb_soluong.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {          
            


            BangGioHangChiTiet item = new BangGioHangChiTiet()
            { 
                DonGia = Convert.ToInt32(tb_dongia.Text),
                SoLuong = Convert.ToInt32(tb_soluong.Text),               
            };
            _iGioHangCTService.Add(item);
            MessageBox.Show("Thêm thành công");
            LoadtoData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _GHCT = _iGioHangCTService.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_dongia.Text = r.Cells[1].Value.ToString();
                tb_soluong.Text = r.Cells[2].Value.ToString();

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
           ResetForm();

        }
    }
}
