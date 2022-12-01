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
namespace _3.PL.Views
{
    public partial class FrmMauSac : Form
    {
        private IMauSacService _service = new MauSacService();
        public BangMauSac _MS = new BangMauSac();
        public FrmMauSac()
        {
            InitializeComponent();
            LoadTodata();
        }
        public void LoadTodata() 
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Stt";
            dataGridView1.Columns[2].Name = "Ma";
            dataGridView1.Columns[3].Name = "Ten";
            dataGridView1.Rows.Clear();
            foreach(var item in _service.GetAll())
            {
                dataGridView1.Rows.Add(item.Id,stt++,item.MaMs,item.TenMs);
            }
        }
        public void Reset()
        {
            LoadTodata();
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
                _MS = _service.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                tbt_Ma.Text = dt.Cells[2].Value.ToString();
                tbt_Ten.Text = dt.Cells[3].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu sắc");
            }
            else if (_service.GetAll().Any(x => x.MaMs == tbt_Ma.Text))
            {
                MessageBox.Show("Mã Màu sắc này đã tồn tại");
            }
            else
            {
                var ms = new BangMauSac()
                {
                    Id = new Guid(),
                    MaMs = tbt_Ma.Text,
                    TenMs = tbt_Ten.Text,
                };
                _service.Add(ms);
                MessageBox.Show("Thêm màu sắc thành công");
                Reset();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tbt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu sắc");
            }
            else if (_MS == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_MS.MaMs == tbt_Ma.Text || (_MS.MaMs != tbt_Ma.Text && _service.GetAll().FirstOrDefault(x => x.MaMs == tbt_Ma.Text) == null))
                {
                    _MS.MaMs = tbt_Ma.Text;
                    _MS.TenMs = tbt_Ten.Text;
                    _service.Update(_MS);
                    MessageBox.Show("Sửa màu sắc thành công");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Mã màu sắc đã tồn tại");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_MS == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                _service.Delete(_MS);
                MessageBox.Show("Xóa màu sắc thành công");
                Reset();
            }
        }
    }
}
