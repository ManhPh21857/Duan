using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Presentation;
namespace _3.PL.ViewsFrm
{
    public partial class FrmNhanVien : Form
    {
        FrmBanHang banHang = new FrmBanHang();
        IChucVuService _IChucVuService;
        INhanVienService _INhanVienService;
        BangNhanVien nhanvien;
        public FrmNhanVien()
        {
            
            InitializeComponent();
            _IChucVuService = new ChucVuService();
            _INhanVienService = new NhanVienService();
            nhanvien = new BangNhanVien();
            foreach (var chucvu in _IChucVuService.GetAll())
            {
                cbb_chucvu.Items.Add(chucvu.TenCV);
            }
            rb_hoatdong.Checked = true;
            rb_nam.Checked = true;
            foreach (var chucvu in _IChucVuService.GetAll())
            {
                cbb_locChucVu.Items.Add(chucvu.TenCV);
                
            }
            cbb_locTrangThai.Items.Add("Hoạt Động");
            cbb_locTrangThai.Items.Add("Không Hoạt Động");
            dtp_ngaysinh.CustomFormat = "dd/MM/yyyy";
            LoadNhanVien();
        }
        public void LoadNhanVien()
        {
            dtg_view_nv.ColumnCount = 9;
            dtg_view_nv.Columns[0].Name = "ID";
            dtg_view_nv.Columns[0].Visible = true;
            dtg_view_nv.Columns[1].Name = "Mã Nhân Viên";
            dtg_view_nv.Columns[2].Name = "Tên Nhân Viên";
            dtg_view_nv.Columns[3].Name = "Số Điện Thoại";
            dtg_view_nv.Columns[4].Name = "Địa Chỉ";
            dtg_view_nv.Columns[5].Name = "Giới Tính";
            dtg_view_nv.Columns[6].Name = "Chức Vụ";
            dtg_view_nv.Columns[7].Name = "Trạng Thái";
            dtg_view_nv.Columns[8].Name = "Mật Khẩu";
           // dtg_view_nv.Columns[9].Name = "Mật Khẩu";
            dtg_view_nv.Rows.Clear();

            foreach (var nhanvien in _INhanVienService.GetAll())
            {
                //string Custombirthday = nhanvien.NgaySinh.ToString("dd-MM-yyyy");
                dtg_view_nv.Rows.Add(
                    nhanvien.Ma,
                    string.Concat(nhanvien.Ho," ",nhanvien.TenDem," ",nhanvien.Ten), 
                    nhanvien.SDT,
                    nhanvien.DiaChi, 
                    nhanvien.GioiTinh, 
                    _IChucVuService.GetAll().Where(p => p.Id == nhanvien.IdCV).Select(p => p.TenCV).FirstOrDefault(), 
                    nhanvien.TrangThai == 1 ? "Hoạt Đông" : "Không Hoạt Động",
                    nhanvien.NgaySinh.ToString("dd-MM-yyyy"),
                    nhanvien.MatKhau);
            }
            cbb_chucvu.SelectedItem = 1;
        }
        //public bool CheckValueDate()
        //{
        //    string name = txb_Ho.Text;
        //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})+)$");
        //    Match match = regex.Match(name);
        //    //if (!match.Success)
        //    //{
        //    //    MessageBox.Show("Tên Nhân viên không hợp lệ.");
        //    //    txb_Ho.Text = "";
        //    //    return false;
        //    //}
        //    if(txb_Ho.Text.Length == 0)
        //    {
        //        MessageBox.Show("Tên nhân viên không được bỏ trống.");
        //        return false;
        //    }if(txb_Ho.Text.Length < 5)
        //    {
        //        MessageBox.Show("Tên nhân viên tối thiểu 5 ký tự.");
        //        return false;
        //    }if (tbt_sdt.Text.Length < 10)
        //    {
        //        MessageBox.Show("Số điện thoại không hợp lệ");
        //        return false;
        //    }
        //    if (!tbt_sdt.Text.All(char.IsNumber)){
        //        MessageBox.Show("Số điện thoại phải là số.");
        //        return false;
        //    }if (tbt_diachi.Text.Length == 0)
        //    {
        //        MessageBox.Show("Địa chỉ không được để trống.");
        //        return false;
        //    }
        //    //}if(pictureBox_avt.Image == null)
        //    //{
        //    //    MessageBox.Show("Nhân viên chưa cập nhật ảnh đại diện.");
        //    //    return false;
        //    //}
        //    return true;
        //}

       

        

   


        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_chucvu.Text != "")
            {
                if(cbb_locTrangThai.Text == "Hoạt Động")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                              // && p.IdCV  ==  cbb_locChucVu.SelectedIndex 
                                                               // && p.TrangThai == 0
                                                                );
                    dtg_view_nv.Rows.Clear();
                    foreach (var nhanvien in timkiem)
                    {
                        dtg_view_nv.Rows.Add(
                            nhanvien.Ma,
                    string.Concat(nhanvien.Ho, " ", nhanvien.TenDem, " ", nhanvien.Ten),
                    nhanvien.SDT,
                    nhanvien.DiaChi,
                    nhanvien.GioiTinh,
                    _IChucVuService.GetAll().Where(p => p.Id == nhanvien.IdCV).Select(p => p.TenCV).FirstOrDefault(),
                    nhanvien.TrangThai == 1 ? "Hoạt Đông" : "Không Hoạt Động",
                    nhanvien.NgaySinh.ToString("dd-MM-yyyy"),
                    nhanvien.MatKhau
                            );
                    }
                }
                if(cbb_locTrangThai.Text == "Không Hoạt Động")
                {

                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
     
                                                                );
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
                if(cbb_locTrangThai.Text == "")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                                //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                                //&& p.TrangThai == 1
                                                                );
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if(cbb_locChucVu.Text == "")
            {
                if (cbb_locTrangThai.Text == "Hoạt Động")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                                //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                                && p.TrangThai == 0);
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
                if (cbb_locTrangThai.Text == "Không Hoạt Động")
                {

                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                                //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                                && p.TrangThai == 1);
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
                if (cbb_locTrangThai.Text == "")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                                //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                                //&& p.TrangThai == 1
                                                                );
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if(cbb_locTrangThai.Text == "Hoạt Động")
            {
                if(cbb_locChucVu.Text == "")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                               //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                               && p.TrangThai == 0
                                                               );
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if (cbb_locTrangThai.Text == "Không Hoạt Động")
            {
                if (cbb_locChucVu.Text == "")
                {
                    var timkiem = _INhanVienService.GetAll().Where(p => string.Concat(p.Ho, " ", p.TenDem, " ", p.Ten).Contains(txt_timkiem.Text)
                                                               //&& p.IdCV == cbb_locChucVu.SelectedIndex  
                                                               && p.TrangThai == 1
                                                               );
                    dtg_view_nv.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dtg_view_nv.Rows.Add(item.Ma, item.Ten, item.SDT, item.DiaChi, item.GioiTinh, _IChucVuService.GetAll().Where(p => p.Id == item.IdCV).Select(p => p.TenCV).FirstOrDefault(), item.TrangThai, item.NgaySinh.ToString("dd-MM-yyyy"));
                    }
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var checksdt = _INhanVienService.GetAll().FirstOrDefault(p => p.SDT == tbt_sdt.Text);
            var manhanvien = _INhanVienService.GetAll().Count() + 1;
            //!CheckValueDate()
            //if ()
            //{

            //}
           // else
           // { 
                if (checksdt != null)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.");
                }
                else
                {

                    BangNhanVien nv = new BangNhanVien()
                    {
                        Id = new Guid(),
                        MatKhau = txb_matkhau.Text,
                        Ma = "NV" + manhanvien,
                        Ho = txb_Ho.Text,
                        TenDem = txb_tendem.Text,
                        Ten = txb_tennv.Text,
                        SDT = tbt_sdt.Text,
                        DiaChi = tbt_diachi.Text,
                        GioiTinh = rb_nam.Checked ? "Nam" : "Nữ",
                        IdCV = _IChucVuService.GetAll().FirstOrDefault(x => x.TenCV == cbb_chucvu.Text).Id,
                        TrangThai = rb_hoatdong.Checked ? 1 : 0,
                        NgaySinh = dtp_ngaysinh.Value

                    };
                    _INhanVienService.Add(nv);
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                    LoadNhanVien();

                }
           // }
            }

        private void dtg_view_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtg_view_nv.Rows[e.RowIndex];
            nhanvien = _INhanVienService.GetAll().FirstOrDefault(p => p.Ma == r.Cells[0].Value.ToString());
           txb_matkhau.Text = r.Cells[8].Value.ToString();
            txb_Ho.Text = nhanvien.Ho;
            txb_tendem.Text = nhanvien.TenDem;
            txb_tennv.Text = nhanvien.Ten;
            tbt_sdt.Text = r.Cells[2].Value.ToString();
            tbt_diachi.Text = r.Cells[3].Value.ToString();
            rb_nam.Checked = r.Cells[4].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = r.Cells[4].Value.ToString() == "Nữ" ? true : false;
            cbb_chucvu.Text = r.Cells[5].Value.ToString();
            rb_hoatdong.Checked = r.Cells[6].Value.ToString() == "Hoạt Động" ? true : false;
            rb_khonghoatdong.Checked = r.Cells[6].Value.ToString() == "Không Hoạt Động" ? true : false;
            dtp_ngaysinh.Value = nhanvien.NgaySinh;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nhanvien.MatKhau = txb_matkhau.Text;
            nhanvien.Ten = txb_Ho.Text;
            nhanvien.SDT = tbt_sdt.Text;
            nhanvien.DiaChi = tbt_diachi.Text;
            nhanvien.GioiTinh = rb_nam.Text;
            nhanvien.IdCV = _IChucVuService.GetAll().FirstOrDefault(x => x.TenCV == cbb_chucvu.Text).Id;

            nhanvien.TrangThai = rb_hoatdong.Checked ? 1 : 0;
            nhanvien.NgaySinh = dtp_ngaysinh.Value;
            if (nhanvien.SDT == tbt_sdt.Text)
            {
                _INhanVienService.Update(nhanvien);
                MessageBox.Show("Sửa nhân viên thành công");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
 