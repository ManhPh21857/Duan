namespace _3.PL.Views
{
    partial class FrmGioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_nguoinhan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_khachhang = new System.Windows.Forms.ComboBox();
            this.cb_ctt = new System.Windows.Forms.CheckBox();
            this.cb_tt = new System.Windows.Forms.CheckBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.dtp_ngtt = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngtao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_Show);
            this.groupBox1.Location = new System.Drawing.Point(14, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ Hàng";
            // 
            // dtg_Show
            // 
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(6, 37);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(1082, 211);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_sdt);
            this.groupBox2.Controls.Add(this.tb_diachi);
            this.groupBox2.Controls.Add(this.tb_nguoinhan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbb_nhanvien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbb_khachhang);
            this.groupBox2.Controls.Add(this.cb_ctt);
            this.groupBox2.Controls.Add(this.cb_tt);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Controls.Add(this.dtp_ngtt);
            this.groupBox2.Controls.Add(this.dtp_ngtao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(541, 150);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(245, 26);
            this.tb_sdt.TabIndex = 25;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(541, 92);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(245, 26);
            this.tb_diachi.TabIndex = 24;
            // 
            // tb_nguoinhan
            // 
            this.tb_nguoinhan.Location = new System.Drawing.Point(541, 41);
            this.tb_nguoinhan.Name = "tb_nguoinhan";
            this.tb_nguoinhan.Size = new System.Drawing.Size(245, 26);
            this.tb_nguoinhan.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "SDT";
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(129, 222);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(245, 27);
            this.cbb_nhanvien.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // cbb_khachhang
            // 
            this.cbb_khachhang.FormattingEnabled = true;
            this.cbb_khachhang.Location = new System.Drawing.Point(129, 176);
            this.cbb_khachhang.Name = "cbb_khachhang";
            this.cbb_khachhang.Size = new System.Drawing.Size(245, 27);
            this.cbb_khachhang.TabIndex = 15;
            // 
            // cb_ctt
            // 
            this.cb_ctt.AutoSize = true;
            this.cb_ctt.Location = new System.Drawing.Point(651, 221);
            this.cb_ctt.Name = "cb_ctt";
            this.cb_ctt.Size = new System.Drawing.Size(135, 23);
            this.cb_ctt.TabIndex = 12;
            this.cb_ctt.Text = "Chưa Thanh Toán";
            this.cb_ctt.UseVisualStyleBackColor = true;
            this.cb_ctt.Click += new System.EventHandler(this.cb_ctt_Click);
            // 
            // cb_tt
            // 
            this.cb_tt.AutoSize = true;
            this.cb_tt.Location = new System.Drawing.Point(508, 222);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(120, 23);
            this.cb_tt.TabIndex = 11;
            this.cb_tt.Text = "Đã Thanh Toán";
            this.cb_tt.UseVisualStyleBackColor = true;
            this.cb_tt.Click += new System.EventHandler(this.cb_tt_Click);
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(129, 35);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(250, 26);
            this.tb_ma.TabIndex = 8;
            // 
            // dtp_ngtt
            // 
            this.dtp_ngtt.Location = new System.Drawing.Point(129, 125);
            this.dtp_ngtt.Name = "dtp_ngtt";
            this.dtp_ngtt.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngtt.TabIndex = 7;
            // 
            // dtp_ngtao
            // 
            this.dtp_ngtao.Location = new System.Drawing.Point(129, 85);
            this.dtp_ngtao.Name = "dtp_ngtao";
            this.dtp_ngtao.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngtao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người Nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày thanh toán ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_lammoi);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(826, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 287);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(35, 230);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(215, 44);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(35, 168);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(215, 44);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(35, 107);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(215, 44);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(35, 48);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(215, 44);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(14, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1094, 176);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Sản Phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 743);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGioHang";
            this.Text = "FrmGioHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private DataGridView dtg_Show;
        private GroupBox groupBox2;
        private CheckBox cb_ctt;
        private CheckBox cb_tt;
        private TextBox tb_ma;
        private DateTimePicker dtp_ngtt;
        private DateTimePicker dtp_ngtao;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private ComboBox cbb_khachhang;
        private ComboBox cbb_nhanvien;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tb_sdt;
        private TextBox tb_diachi;
        private TextBox tb_nguoinhan;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}