using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.IReposi;
using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.Services;

namespace _3.PL.ViewsFrm
{
    public partial class frmChucvu : Form
    {
        BangChucVu _CV;
        IChucVuService ichucvuservice;
        BangNhanVien nhanvien;
        public frmChucvu()
        {
            _CV = new BangChucVu();
            InitializeComponent();
            ichucvuservice = new ChucVuService();
            nhanvien = new BangNhanVien();
            LoadNhanVien();
        }
        public void LoadNhanVien()
        {
            dtg_show_nv.ColumnCount = 3;

            dtg_show_nv.Columns[0].Name = "ID";
            dtg_show_nv.Columns[0].Visible = false;
            dtg_show_nv.Columns[1].Name = "Mã";
            dtg_show_nv.Columns[2].Name = "Tên";
            dtg_show_nv.Rows.Clear();
            foreach (var item in ichucvuservice.GetAll())
            {
                dtg_show_nv.Rows.Add(item.Id,item.MaCV, item.TenCV);
            }
        }


        private void dtg_show_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show_nv.Rows[e.RowIndex];
                _CV = ichucvuservice.GetAll().FirstOrDefault(p => p.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã");
            }
            else
            {
                var item = new BangChucVu()
                {
                    Id = new Guid(),
                    MaCV = tb_ma.Text,
                    TenCV = tb_ten.Text,
                };
                ichucvuservice.Add(item);
                MessageBox.Show("Thêm thành công");
                LoadNhanVien();
            }
        }
    }
}
