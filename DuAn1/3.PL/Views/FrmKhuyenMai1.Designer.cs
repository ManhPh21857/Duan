namespace _3.PL.Views
{
    partial class FrmKhuyenMai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_Showkhuyenmai = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_giamgia = new System.Windows.Forms.TextBox();
            this.dtp_ngkk = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngbd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Showkhuyenmai)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dtg_Showkhuyenmai);
            this.groupBox2.Location = new System.Drawing.Point(211, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1247, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khuyến mãi ";
            // 
            // dtg_Showkhuyenmai
            // 
            this.dtg_Showkhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Showkhuyenmai.Location = new System.Drawing.Point(6, 66);
            this.dtg_Showkhuyenmai.Name = "dtg_Showkhuyenmai";
            this.dtg_Showkhuyenmai.RowHeadersWidth = 51;
            this.dtg_Showkhuyenmai.RowTemplate.Height = 29;
            this.dtg_Showkhuyenmai.Size = new System.Drawing.Size(1228, 246);
            this.dtg_Showkhuyenmai.TabIndex = 0;
            this.dtg_Showkhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Showkhuyenmai_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.tb_mota);
            this.groupBox3.Controls.Add(this.tb_ma);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_giamgia);
            this.groupBox3.Controls.Add(this.dtp_ngkk);
            this.groupBox3.Controls.Add(this.dtp_ngbd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(217, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 332);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khuyến mãi";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(155, 165);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(242, 26);
            this.tb_mota.TabIndex = 15;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(155, 81);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(242, 26);
            this.tb_ma.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã khuyến mãi: ";
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Location = new System.Drawing.Point(155, 246);
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.Size = new System.Drawing.Size(242, 26);
            this.tb_giamgia.TabIndex = 7;
            // 
            // dtp_ngkk
            // 
            this.dtp_ngkk.Location = new System.Drawing.Point(567, 160);
            this.dtp_ngkk.Name = "dtp_ngkk";
            this.dtp_ngkk.Size = new System.Drawing.Size(260, 26);
            this.dtp_ngkk.TabIndex = 5;
            // 
            // dtp_ngbd
            // 
            this.dtp_ngbd.Location = new System.Drawing.Point(585, 81);
            this.dtp_ngbd.Name = "dtp_ngbd";
            this.dtp_ngbd.Size = new System.Drawing.Size(242, 26);
            this.dtp_ngbd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mức giảm giá: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(476, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(476, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mô tả khuyến mãi: ";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lammoi.Location = new System.Drawing.Point(47, 265);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(302, 38);
            this.btn_lammoi.TabIndex = 11;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_xoa.Location = new System.Drawing.Point(47, 194);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(302, 38);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_capnhat.Location = new System.Drawing.Point(47, 129);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(302, 38);
            this.btn_capnhat.TabIndex = 9;
            this.btn_capnhat.Text = "Cập nhật ";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them.Location = new System.Drawing.Point(47, 57);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(302, 38);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Location = new System.Drawing.Point(1066, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 332);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khuyến mãi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(18, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox15.Controls.Add(this.button13);
            this.groupBox15.Controls.Add(this.button5);
            this.groupBox15.Controls.Add(this.button4);
            this.groupBox15.Controls.Add(this.button3);
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Controls.Add(this.pictureBox1);
            this.groupBox15.Controls.Add(this.btn_banhang);
            this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox15.Location = new System.Drawing.Point(1, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(210, 711);
            this.groupBox15.TabIndex = 16;
            this.groupBox15.TabStop = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(-1, 418);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(253, 73);
            this.button13.TabIndex = 12;
            this.button13.Text = "Thống Kê";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-1, 634);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 77);
            this.button5.TabIndex = 11;
            this.button5.Text = "Đăng Xuất";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 73);
            this.button4.TabIndex = 10;
            this.button4.Text = "Nhân Viên";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "Khuyễn Mãi";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 73);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sản Phẩm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_3.PL.Properties.Resources.logo_shop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_banhang
            // 
            this.btn_banhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_banhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_banhang.BackgroundImage")));
            this.btn_banhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_banhang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_banhang.ForeColor = System.Drawing.Color.Black;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(0, 141);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(252, 73);
            this.btn_banhang.TabIndex = 0;
            this.btn_banhang.Text = "Bán Hàng";
            this.btn_banhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_banhang.UseVisualStyleBackColor = false;
            // 
            // FrmKhuyenMai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 716);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmKhuyenMai1";
            this.Text = "FrmKhuyenMai";
            this.Load += new System.EventHandler(this.FrmKhuyenMai1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Showkhuyenmai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dtg_Showkhuyenmai;
        private GroupBox groupBox3;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Button btn_them;
        private TextBox tb_giamgia;
        private DateTimePicker dtp_ngkk;
        private DateTimePicker dtp_ngbd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_ma;
        private Label label5;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox tb_mota;
        private GroupBox groupBox15;
        private Button button13;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btn_banhang;
    }
}