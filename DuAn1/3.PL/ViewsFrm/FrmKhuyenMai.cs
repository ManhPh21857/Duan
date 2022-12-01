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
using _2.BUS.Service;
using _2.BUS.IService;

namespace _3.PL.ViewsFrm
{
    public partial class FrmKhuyenMai : Form
    {
        public BangKhuyenMai _KM;
        public IKhuyenMaiService _service; 
        public FrmKhuyenMai()
        {
            _KM = new BangKhuyenMai();
            _service = new KhuyenMaiService();
            InitializeComponent();
            Loaddata();
        }
        public void Loaddata()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Stt";
            dataGridView1.Columns[2].Name = "Mã Khuyến Mại";
            dataGridView1.Columns[3].Name = "Mô tả";
            dataGridView1.Rows.Clear();
            foreach (var item in _service.GetAll())
            {
                dataGridView1.Rows.Add(item.Id, stt++, item.MaKM, item.MotaKM);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
                _KM = _service.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dt.Cells[0].Value.ToString()));
                tbt_Ma.Text = dt.Cells[2].Value.ToString();
                tbt_Ten.Text = dt.Cells[3].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khuyễn mại");
            }
            else
            {
                var add = new BangKhuyenMai()
                {
                    Id = new Guid(),
                    MaKM = tbt_Ma.Text,
                    MotaKM = tbt_Ten.Text,
                };
                _service.Add(add);
                MessageBox.Show("Thêm thành công");
                Loaddata();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(tbt_Ma.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyễn mãi");
            }
            else
            {
                if (_KM.MaKM == tbt_Ma.Text || (_KM.MaKM != tbt_Ma.Text && _service.GetAll().FirstOrDefault(x => x.MaKM == tbt_Ma.Text) == null))
                {
                    _KM.MaKM = tbt_Ma.Text;
                    _KM.MotaKM = tbt_Ten.Text;
                    _service.Update(_KM);
                    MessageBox.Show("Sửa màu sắc thành công");
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Mã khuyến mại đã tồn tại");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_KM == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                _service.Delete(_KM);
                MessageBox.Show("Xóa Loại thành công");
                Loaddata();
            }
        }
    }
}
