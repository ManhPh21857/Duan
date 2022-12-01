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
namespace _3.PL.ViewsFrm
{
    public partial class FrmLoaiSP : Form
    {
        private ILoaiService _loaiService = new LoaiSPService();
        private BangLoaiSP _Loai = new BangLoaiSP();
        public FrmLoaiSP()
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
            foreach (var item in _loaiService.GetAll())
            {
                dataGridView1.Rows.Add(item.Id, stt++, item.MaLoai, item.TenLoai);
            }
        }
        public void ResetFrm()
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
                _Loai = _loaiService.GetAll().FirstOrDefault(p => p.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
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
            else if (_loaiService.GetAll().Any(x => x.MaLoai == tbt_Ma.Text))
            {
                MessageBox.Show("Mã Màu sắc này đã tồn tại");
            }
            else
            {
                var ms = new BangLoaiSP()
                {
                    Id = new Guid(),
                    MaLoai = tbt_Ma.Text,
                    TenLoai = tbt_Ten.Text,
                };
                _loaiService.Add(ms);
                MessageBox.Show("Thêm màu sắc thành công");
                ResetFrm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tbt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu sắc");
            }
            else if (_Loai == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_Loai.MaLoai == tbt_Ma.Text || (_Loai.MaLoai != tbt_Ma.Text && _loaiService.GetAll().FirstOrDefault(x => x.MaLoai == tbt_Ma.Text) == null))
                {
                    _Loai.MaLoai = tbt_Ma.Text;
                    _Loai.TenLoai = tbt_Ten.Text;
                    _loaiService.Update(_Loai);
                    MessageBox.Show("Sửa màu sắc thành công");
                    ResetFrm();
                }
                else
                {
                    MessageBox.Show("Mã Loại đã tồn tại");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_Loai == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                _loaiService.Delete(_Loai);
                MessageBox.Show("Xóa Loại thành công");
                ResetFrm();
            }
        }
    }
}
