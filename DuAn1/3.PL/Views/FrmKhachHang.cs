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
namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        public IKhachHangService _khachHangService = new KhachHangService();
        public BangKhachHang _KH = new BangKhachHang();
        List<BangKhachHang> _khachHangList = new List<BangKhachHang>();
        public FrmKhachHang()
        {
            LoadToData();
            InitializeComponent();
        }
        public void LoadToData()
        {
            dtg_show.ColumnCount = 4;
            int stt = 1;
            dtg_show.Columns[0].Name = "id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Ho va Ten";
            dtg_show.Rows.Clear();
            var lst = _khachHangService.GetAll();

            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++, string.Concat(item.Ho," ",item.TenDem," ",item.Ten));
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui long nhap ma khach hang");
            }else if (_khachHangService.GetAll().Any(p => p.Ma == tb_ma.Text))  
            {
                MessageBox.Show("Ma khach hang da ton tai");
            }
            else
            {
                var item = new BangKhachHang()
                {

                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text,
                    Ho = tb_ho.Text,
                    TenDem = tb_tendem.Text,

                };
                _khachHangService.Add(item);
                MessageBox.Show("Thêm thành công");
                LoadToData();
            }

            
            

        }

    }
}
