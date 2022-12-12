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
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _1.DAL.Models;
namespace _3.PL.Views
{
    public partial class ChiTietSanPham : Form
    {

        IChiTietSPService _ICTSP = new ChiTietSPService();
        public ChiTietSanPham()
        {
            InitializeComponent();
            Loadtodata();
        }
        public void Loadtodata()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
