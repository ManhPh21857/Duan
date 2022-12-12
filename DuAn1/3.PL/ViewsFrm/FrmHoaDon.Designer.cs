namespace _3.PL.ViewData
{
    partial class FrmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_chuathanhtoan = new System.Windows.Forms.RadioButton();
            this.rb_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.cbb_khachhang = new System.Windows.Forms.ComboBox();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.dtp_ngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayship = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_tenngnhan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_show);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Hóa Đơn";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(6, 25);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(1238, 163);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_chuathanhtoan);
            this.groupBox2.Controls.Add(this.rb_dathanhtoan);
            this.groupBox2.Controls.Add(this.cbb_khachhang);
            this.groupBox2.Controls.Add(this.cbb_nhanvien);
            this.groupBox2.Controls.Add(this.dtp_ngaynhan);
            this.groupBox2.Controls.Add(this.dtp_ngayship);
            this.groupBox2.Controls.Add(this.dtp_ngaythanhtoan);
            this.groupBox2.Controls.Add(this.dtp_ngaytao);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.tb_diachi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_sdt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_tenngnhan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1133, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // rb_chuathanhtoan
            // 
            this.rb_chuathanhtoan.AutoSize = true;
            this.rb_chuathanhtoan.Location = new System.Drawing.Point(615, 301);
            this.rb_chuathanhtoan.Name = "rb_chuathanhtoan";
            this.rb_chuathanhtoan.Size = new System.Drawing.Size(134, 23);
            this.rb_chuathanhtoan.TabIndex = 45;
            this.rb_chuathanhtoan.TabStop = true;
            this.rb_chuathanhtoan.Text = "Chưa Thanh Toán";
            this.rb_chuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rb_dathanhtoan
            // 
            this.rb_dathanhtoan.AutoSize = true;
            this.rb_dathanhtoan.Location = new System.Drawing.Point(473, 301);
            this.rb_dathanhtoan.Name = "rb_dathanhtoan";
            this.rb_dathanhtoan.Size = new System.Drawing.Size(119, 23);
            this.rb_dathanhtoan.TabIndex = 44;
            this.rb_dathanhtoan.TabStop = true;
            this.rb_dathanhtoan.Text = "Đã Thanh Toán";
            this.rb_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // cbb_khachhang
            // 
            this.cbb_khachhang.FormattingEnabled = true;
            this.cbb_khachhang.Location = new System.Drawing.Point(63, 189);
            this.cbb_khachhang.Name = "cbb_khachhang";
            this.cbb_khachhang.Size = new System.Drawing.Size(261, 27);
            this.cbb_khachhang.TabIndex = 43;
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(63, 129);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(261, 27);
            this.cbb_nhanvien.TabIndex = 42;
            // 
            // dtp_ngaynhan
            // 
            this.dtp_ngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaynhan.Location = new System.Drawing.Point(473, 244);
            this.dtp_ngaynhan.Name = "dtp_ngaynhan";
            this.dtp_ngaynhan.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngaynhan.TabIndex = 41;
            // 
            // dtp_ngayship
            // 
            this.dtp_ngayship.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayship.Location = new System.Drawing.Point(473, 187);
            this.dtp_ngayship.Name = "dtp_ngayship";
            this.dtp_ngayship.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngayship.TabIndex = 40;
            // 
            // dtp_ngaythanhtoan
            // 
            this.dtp_ngaythanhtoan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaythanhtoan.Location = new System.Drawing.Point(473, 129);
            this.dtp_ngaythanhtoan.Name = "dtp_ngaythanhtoan";
            this.dtp_ngaythanhtoan.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngaythanhtoan.TabIndex = 39;
            // 
            // dtp_ngaytao
            // 
            this.dtp_ngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaytao.Location = new System.Drawing.Point(473, 71);
            this.dtp_ngaytao.Name = "dtp_ngaytao";
            this.dtp_ngaytao.Size = new System.Drawing.Size(250, 26);
            this.dtp_ngaytao.TabIndex = 38;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(911, 256);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(200, 68);
            this.btn_Reset.TabIndex = 37;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(911, 176);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(200, 68);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Location = new System.Drawing.Point(911, 94);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(200, 68);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_diachi.Location = new System.Drawing.Point(63, 354);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(261, 26);
            this.tb_diachi.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(63, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Địa Chỉ";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.Location = new System.Drawing.Point(63, 297);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(261, 26);
            this.tb_sdt.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(63, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "SDT";
            // 
            // tb_tenngnhan
            // 
            this.tb_tenngnhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_tenngnhan.Location = new System.Drawing.Point(63, 241);
            this.tb_tenngnhan.Name = "tb_tenngnhan";
            this.tb_tenngnhan.Size = new System.Drawing.Size(261, 26);
            this.tb_tenngnhan.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(63, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tên Người Nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(473, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Nhận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(473, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Ship";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(473, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày Thanh Toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân Viên";
            // 
            // tb_ma
            // 
            this.tb_ma.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_ma.Location = new System.Drawing.Point(63, 71);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(261, 26);
            this.tb_ma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_show;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox tb_ma;
        private Label label1;
        private TextBox tb_tenngnhan;
        private Label label9;
        private TextBox tb_diachi;
        private Label label10;
        private TextBox tb_sdt;
        private Label label11;
        private Button btn_Reset;
        private Button btn_Sua;
        private Button btn_Them;
        private DateTimePicker dtp_ngaynhan;
        private DateTimePicker dtp_ngayship;
        private DateTimePicker dtp_ngaythanhtoan;
        private DateTimePicker dtp_ngaytao;
        private ComboBox cbb_khachhang;
        private ComboBox cbb_nhanvien;
        private RadioButton rb_chuathanhtoan;
        private RadioButton rb_dathanhtoan;
    }
}