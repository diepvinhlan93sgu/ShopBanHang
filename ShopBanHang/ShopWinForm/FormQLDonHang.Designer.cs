namespace ShopWinForm
{
    partial class FormQLDonHang
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
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.txtmadonhang = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboTrangthai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCtDonHang = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dvDonhang = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDonhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtiduser
            // 
            this.txtiduser.Location = new System.Drawing.Point(23, 209);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.Size = new System.Drawing.Size(100, 20);
            this.txtiduser.TabIndex = 4;
            this.txtiduser.Visible = false;
            // 
            // txtmadonhang
            // 
            this.txtmadonhang.Location = new System.Drawing.Point(23, 168);
            this.txtmadonhang.Name = "txtmadonhang";
            this.txtmadonhang.Size = new System.Drawing.Size(100, 20);
            this.txtmadonhang.TabIndex = 3;
            this.txtmadonhang.Visible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(78, 89);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng Thái Đơn Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtiduser);
            this.groupBox2.Controls.Add(this.txtmadonhang);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.CboTrangthai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 518);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng Thái Đơn Hàng";
            // 
            // CboTrangthai
            // 
            this.CboTrangthai.FormattingEnabled = true;
            this.CboTrangthai.Location = new System.Drawing.Point(23, 62);
            this.CboTrangthai.Name = "CboTrangthai";
            this.CboTrangthai.Size = new System.Drawing.Size(130, 21);
            this.CboTrangthai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chọn ngày cần xem";
            // 
            // TriGia
            // 
            this.TriGia.DataPropertyName = "TriGiaDH";
            this.TriGia.HeaderText = "Trị Giá";
            this.TriGia.Name = "TriGia";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "IDUser";
            this.TenKH.HeaderText = "User Đặt Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaDonHang";
            this.MaHD.HeaderText = "Mã Đơn Hàng";
            this.MaHD.Name = "MaHD";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(143, 62);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 20);
            this.dtNgay.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(120, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quản Lý Đơn Hàng";
            // 
            // btnCtDonHang
            // 
            this.btnCtDonHang.Location = new System.Drawing.Point(173, 472);
            this.btnCtDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnCtDonHang.Name = "btnCtDonHang";
            this.btnCtDonHang.Size = new System.Drawing.Size(146, 28);
            this.btnCtDonHang.TabIndex = 21;
            this.btnCtDonHang.Text = "Xem chi tiết đơn hàng";
            this.btnCtDonHang.UseVisualStyleBackColor = true;
            this.btnCtDonHang.Click += new System.EventHandler(this.btnCtDonHang_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(19, 472);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(146, 28);
            this.btnAll.TabIndex = 20;
            this.btnAll.Text = "Hiển thị tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(362, 61);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 20);
            this.btnXem.TabIndex = 19;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(327, 472);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 28);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dvDonhang
            // 
            this.dvDonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.MaHD,
            this.TenKH,
            this.TriGia});
            this.dvDonhang.Location = new System.Drawing.Point(19, 89);
            this.dvDonhang.Margin = new System.Windows.Forms.Padding(4);
            this.dvDonhang.Name = "dvDonhang";
            this.dvDonhang.Size = new System.Drawing.Size(443, 375);
            this.dvDonhang.TabIndex = 15;
            this.dvDonhang.SelectionChanged += new System.EventHandler(this.dvDonhang_SelectionChanged);
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCtDonHang);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dvDonhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 518);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem Đơn Hàng";
            // 
            // FormQLDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLDonHang";
            this.Text = "FormQLDonHang";
            this.Load += new System.EventHandler(this.FormQLDonHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDonhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtiduser;
        private System.Windows.Forms.TextBox txtmadonhang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboTrangthai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCtDonHang;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dvDonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}