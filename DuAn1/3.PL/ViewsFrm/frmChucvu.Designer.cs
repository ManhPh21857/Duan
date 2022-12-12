namespace _3.PL.ViewsFrm
{
    partial class frmChucvu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tbt_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_show_nv = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_lammoi);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(662, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 286);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc nang";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(114, 182);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(153, 48);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Lam Moi";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(114, 110);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(153, 49);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(114, 44);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(153, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ten);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(216, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 291);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(157, 174);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(262, 26);
            this.tb_ten.TabIndex = 31;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(157, 115);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(262, 26);
            this.tb_ma.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.tbt_timkiem);
            this.groupBox1.Controls.Add(this.dtg_show_nv);
            this.groupBox1.Location = new System.Drawing.Point(200, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách nhân viên ";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(414, 25);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 26);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Location = new System.Drawing.Point(495, 25);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.Size = new System.Drawing.Size(223, 26);
            this.tbt_timkiem.TabIndex = 4;
            // 
            // dtg_show_nv
            // 
            this.dtg_show_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show_nv.Location = new System.Drawing.Point(6, 69);
            this.dtg_show_nv.Name = "dtg_show_nv";
            this.dtg_show_nv.RowHeadersWidth = 51;
            this.dtg_show_nv.RowTemplate.Height = 28;
            this.dtg_show_nv.Size = new System.Drawing.Size(795, 150);
            this.dtg_show_nv.TabIndex = 0;
            this.dtg_show_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_nv_CellClick);
            // 
            // frmChucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChucvu";
            this.Text = "frmChucvu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show_nv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Button btn_lammoi;
        private Button btn_Sua;
        private Button btn_them;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btn_timkiem;
        private TextBox tbt_timkiem;
        private DataGridView dtg_show_nv;
        private Label label5;
        private Label label6;
        private TextBox tb_ten;
        private TextBox tb_ma;
    }
}