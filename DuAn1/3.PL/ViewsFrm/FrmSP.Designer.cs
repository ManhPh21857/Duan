namespace _3.PL.ViewsFrm
{
    partial class FrmSP
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.digrav_show = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digrav_show)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.digrav_show);
            this.panel2.Location = new System.Drawing.Point(2, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 221);
            this.panel2.TabIndex = 4;
            // 
            // digrav_show
            // 
            this.digrav_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.digrav_show.Location = new System.Drawing.Point(3, 3);
            this.digrav_show.Name = "digrav_show";
            this.digrav_show.RowHeadersWidth = 51;
            this.digrav_show.RowTemplate.Height = 29;
            this.digrav_show.Size = new System.Drawing.Size(791, 233);
            this.digrav_show.TabIndex = 0;
            this.digrav_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.digrav_show_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_TimKiem);
            this.panel3.Controls.Add(this.btn_TimKiem);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btn_Sua);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_Them);
            this.panel3.Location = new System.Drawing.Point(422, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 197);
            this.panel3.TabIndex = 3;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(168, 145);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(179, 26);
            this.txt_TimKiem.TabIndex = 4;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(42, 143);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 28);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(141, 85);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 28);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(224, 31);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 28);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(59, 31);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 28);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TenSP);
            this.panel1.Controls.Add(this.txt_Ma);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 197);
            this.panel1.TabIndex = 2;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(133, 83);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(125, 26);
            this.txt_TenSP.TabIndex = 3;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(133, 25);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(125, 26);
            this.txt_Ma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // FrmSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSP";
            this.Text = "FrmSP";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digrav_show)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private DataGridView digrav_show;
        private Panel panel3;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button button2;
        private Button btn_Them;
        private Panel panel1;
        private TextBox txt_TenSP;
        private TextBox txt_Ma;
        private Label label2;
        private Label label1;
    }
}