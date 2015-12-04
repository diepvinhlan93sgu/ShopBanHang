namespace ShopWinForm
{
    partial class FormSanPham
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtha = new System.Windows.Forms.TextBox();
            this.pichinhanh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDanhmuc = new System.Windows.Forms.ComboBox();
            this.txtmota = new System.Windows.Forms.RichTextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvSanpham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(812, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 27);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(812, 497);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 28);
            this.btnThoat.TabIndex = 80;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnthem.Location = new System.Drawing.Point(812, 291);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(83, 28);
            this.btnthem.TabIndex = 76;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsua.Location = new System.Drawing.Point(812, 345);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 28);
            this.btnsua.TabIndex = 77;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btntaomoi
            // 
            this.btntaomoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntaomoi.Location = new System.Drawing.Point(812, 237);
            this.btntaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(83, 28);
            this.btntaomoi.TabIndex = 78;
            this.btntaomoi.Text = "Xóa form";
            this.btntaomoi.UseVisualStyleBackColor = true;
            // 
            // btnchon
            // 
            this.btnchon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnchon.Location = new System.Drawing.Point(846, 46);
            this.btnchon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(49, 21);
            this.btnchon.TabIndex = 82;
            this.btnchon.Text = "...";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Hình ảnh";
            // 
            // txtha
            // 
            this.txtha.Location = new System.Drawing.Point(727, 46);
            this.txtha.Name = "txtha";
            this.txtha.Size = new System.Drawing.Size(100, 20);
            this.txtha.TabIndex = 74;
            // 
            // pichinhanh
            // 
            this.pichinhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pichinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pichinhanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pichinhanh.Location = new System.Drawing.Point(688, 75);
            this.pichinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.Size = new System.Drawing.Size(208, 145);
            this.pichinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinhanh.TabIndex = 81;
            this.pichinhanh.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Màu";
            // 
            // cboDanhmuc
            // 
            this.cboDanhmuc.FormattingEnabled = true;
            this.cboDanhmuc.Location = new System.Drawing.Point(447, 50);
            this.cboDanhmuc.Name = "cboDanhmuc";
            this.cboDanhmuc.Size = new System.Drawing.Size(176, 21);
            this.cboDanhmuc.TabIndex = 71;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(447, 90);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(176, 83);
            this.txtmota.TabIndex = 72;
            this.txtmota.Text = "";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(447, 200);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Loại danh mục";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Số lượng";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(351, 13);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(76, 20);
            this.txtmasp.TabIndex = 83;
            this.txtmasp.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HinhAnh";
            this.Column5.HeaderText = "Hình";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTa";
            this.Column3.HeaderText = "Mô Tả";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.HeaderText = "Giá";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MauSac";
            this.Column7.HeaderText = "Màu sắc";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenDM";
            this.Column4.HeaderText = "Loại Danh Mục";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSP";
            this.Column1.HeaderText = "Tên Sản Phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // dvSanpham
            // 
            this.dvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dvSanpham.Location = new System.Drawing.Point(13, 237);
            this.dvSanpham.Margin = new System.Windows.Forms.Padding(4);
            this.dvSanpham.Name = "dvSanpham";
            this.dvSanpham.Size = new System.Drawing.Size(744, 288);
            this.dvSanpham.TabIndex = 75;
            this.dvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvSanpham_CellContentClick);
            this.dvSanpham.SelectionChanged += new System.EventHandler(this.dvSanpham_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Tên sản phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(135, 59);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(176, 20);
            this.txttensp.TabIndex = 67;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(135, 106);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(176, 20);
            this.txtsize.TabIndex = 68;
            // 
            // txtmau
            // 
            this.txtmau.Location = new System.Drawing.Point(135, 153);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(176, 20);
            this.txtmau.TabIndex = 69;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(135, 196);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(176, 20);
            this.txtgia.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 58;
            this.label6.Text = "Quản lý sản phẩm";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 529);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmau);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.pichinhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dvSanpham);
            this.Controls.Add(this.txtha);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.cboDanhmuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtha;
        private System.Windows.Forms.PictureBox pichinhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDanhmuc;
        private System.Windows.Forms.RichTextBox txtmota;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dvSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtmau;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label6;


    }
}