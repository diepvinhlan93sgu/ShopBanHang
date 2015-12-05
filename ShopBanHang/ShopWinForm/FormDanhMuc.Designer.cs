namespace ShopWinForm
{
    partial class FormDanhMuc
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
            this.dvDanhmuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmadm = new System.Windows.Forms.TextBox();
            this.txttendm = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnxf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dvDanhmuc
            // 
            this.dvDanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDanhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvDanhmuc.Location = new System.Drawing.Point(21, 125);
            this.dvDanhmuc.Name = "dvDanhmuc";
            this.dvDanhmuc.Size = new System.Drawing.Size(244, 150);
            this.dvDanhmuc.TabIndex = 0;
            this.dvDanhmuc.SelectionChanged += new System.EventHandler(this.dvDanhmuc_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDM";
            this.Column1.HeaderText = "Mã Danh Mục";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDM";
            this.Column2.HeaderText = "Tên Danh Mục";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên danh mục";
            // 
            // txtmadm
            // 
            this.txtmadm.Location = new System.Drawing.Point(121, 52);
            this.txtmadm.Name = "txtmadm";
            this.txtmadm.Size = new System.Drawing.Size(117, 20);
            this.txtmadm.TabIndex = 3;
            // 
            // txttendm
            // 
            this.txttendm.Location = new System.Drawing.Point(121, 91);
            this.txttendm.Name = "txttendm";
            this.txttendm.Size = new System.Drawing.Size(117, 20);
            this.txttendm.TabIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(307, 94);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(307, 139);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(307, 184);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnxf
            // 
            this.btnxf.Location = new System.Drawing.Point(307, 49);
            this.btnxf.Name = "btnxf";
            this.btnxf.Size = new System.Drawing.Size(75, 23);
            this.btnxf.TabIndex = 9;
            this.btnxf.Text = "Xóa form";
            this.btnxf.UseVisualStyleBackColor = true;
            this.btnxf.Click += new System.EventHandler(this.btnxf_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 31);
            this.label6.TabIndex = 110;
            this.label6.Text = "Quản lý Danh Mục";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnxf);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttendm);
            this.Controls.Add(this.txtmadm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvDanhmuc);
            this.Name = "FormDanhMuc";
            this.Text = "FormDanhMuc";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvDanhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmadm;
        private System.Windows.Forms.TextBox txttendm;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnxf;
        private System.Windows.Forms.Label label6;
    }
}