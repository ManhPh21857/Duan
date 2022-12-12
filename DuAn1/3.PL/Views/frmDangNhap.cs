using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Presentation;
namespace _3.PL.Views
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(tb_tendangnhap.Text == "" || tb_matkhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập và mật khẩu");
            }
            else
            {
                if (tb_tendangnhap.Text != "manhvta" || tb_matkhau.Text != "123")
                {
                    MessageBox.Show("Đăng nhập thất bại do sai tk hoặc mk");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                FrmBanHang banhang = new FrmBanHang();
                banhang.ShowDialog();
            }
        }
    }
}
