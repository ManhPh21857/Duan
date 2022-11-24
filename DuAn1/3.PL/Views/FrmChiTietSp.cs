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
    public partial class FrmChiTietSp : Form
    {
        private IChiTietSPService _iCTSPThiTHu;
        List<ChiTietSPView> lst = new List<ChiTietSPView>();
        List<BangChiTietSanPham> _lstThiThu;
        private Guid _id;
        public FrmChiTietSp()
        {
            _iCTSPThiTHu = new ChiTietSPService();
            _lstThiThu = new List<BangChiTietSanPham>();
            InitializeComponent();
        }
        public void LoadToData()
        {
            dtg_show.ColumnCount = 8;
            int stt = 1;
            dtg_show.Columns[0].Name = "id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Tên SP";
            dtg_show.Columns[3].Name = "Mô tả";
            dtg_show.Columns[4].Name = "Số lượng tồn";
            dtg_show.Columns[5].Name = "Giá nhập";
            dtg_show.Columns[6].Name = "Giá bán";
            dtg_show.Columns[7].Name = "Size";
            dtg_show.Rows.Clear();
            var lst = _iCTSPThiTHu.GetAllView();
            
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.ChiTietSP.Id, stt++, item.SanPham.TenSP, item.ChiTietSP.Mota, item.ChiTietSP.Soluongton, item.ChiTietSP.GiaNhap, item.ChiTietSP.GiaBan, item.ChiTietSP.Size);
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var ten = _iCTSPThiTHu.GetAll().FirstOrDefault(p => p.SanPham.TenSP == tb_tensp.Text);
            
            
                BangChiTietSanPham item = new BangChiTietSanPham()
                {

                    Id = ten.Id,

                    Mota = tb_mota.Text,
                    GiaNhap = Convert.ToInt32(tb_gianhap.Text),
                    GiaBan = Convert.ToInt32(tb_giaban.Text),
                    Size = Convert.ToInt32(tb_soluongton.Text),
                };
                _iCTSPThiTHu.Add(item);
                MessageBox.Show("Thêm thành công");
                LoadToData();
            
        }
    }
}
