using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWinForm.ServiceReferenceDanhMucSP;
using ShopWinForm.ServiceReferenceSanPham;
using ShopWinForm.ServiceSanPhamCustom;
using System.IO;

namespace ShopWinForm
{
    public partial class FormSanPham : Form
    {
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        private ServiceSanPhamCustomClient svspc = new ServiceSanPhamCustomClient();
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        private string _hinh = "";
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            btnsua.Visible = false;
            btnDelete.Visible = false;
            dvSanpham.AutoGenerateColumns = false;
            dvSanpham.DataSource = svspc.All();
            cboDanhmuc.DataSource = svdm.All();
            cboDanhmuc.DisplayMember = "TenDM";
            cboDanhmuc.ValueMember = "MaDM";
            var item = new[]
           {
                new { Text = "Còn Hiệu Lực", Value = "0" }, 
                new { Text = "Hết Hiệu Lực", Value = "1" },
                 
           };
            cboTrangthai.DataSource = item;
            cboTrangthai.DisplayMember = "Text";
            cboTrangthai.ValueMember = "value";
            xoaform();
        }

        private void dvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dvSanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (dvSanpham.SelectedRows.Count > 0)
            {

                btnsua.Visible = true;
                btnDelete.Visible = true;

                btnthem.Visible = false;
                SanPhamCustom sp = (SanPhamCustom)dvSanpham.SelectedRows[0].DataBoundItem;
                txtmasp.Text = sp.MaSP.ToString();
                txtsoluong.Text = sp.SoLuong;
                txttensp.Text = sp.TenSP;
                txtmau.Text = sp.MauSac;
                txtmota.Text = sp.MoTa;
                txtsize.Text = sp.KichThuoc;
                txtgia.Text = sp.Gia.ToString();
                txtha.Text = sp.HinhAnh.ToString();
                string urlHinh = "../../../MVCShop/Content/ImageSP/" + sp.HinhAnh;
                pichinhanh.Image = Image.FromFile(urlHinh);
                cboDanhmuc.Text = sp.TenDM;
                //int a = Int32.Parse(sp.TrangThai.ToString());
                //cboTrangthai.SelectedIndex = a;
               
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "file hinh|*.jpg|all file|*.*";
            dlg.InitialDirectory = @"E:\";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = dlg.FileNames;
                foreach (string i in tmp)
                {
                    FileInfo fi = new FileInfo(i);
                    string[] xxx = i.Split('\\');
                    string des = @"../../../MVCShop/Content/ImageSP/" + xxx[xxx.Length - 1];
                    File.Delete(des);

                    //over.
                    fi.CopyTo(des);
                    txtha.Text = "";
                    txtha.Text = des;
                    //MessageBox.Show("Chọn hình ảnh thành công");
                    pichinhanh.Image = Image.FromFile(des);
                    _hinh = Path.GetFileName(des);
                }
            }
        }
        private void xoaform()
        {
            txtha.Clear();
            txtsize.Clear();
            txtmau.Clear();
            txtgia.Clear();
            txtmota.Clear();
            txttensp.Clear();
            txtsoluong.Clear();
            cboDanhmuc.Text = "";
            cboTrangthai.Text = "";
            pichinhanh.Image = null;
        }
        private void btntaomoi_Click(object sender, EventArgs e)
        {
            btnsua.Visible = false;
            btnthem.Visible = true;
            btnDelete.Visible = false;

            xoaform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này !!!", "Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int masp = Int32.Parse(txtmasp.Text.ToString().Trim());
                svsp.XoaSanPham(masp);
                dvSanpham.DataSource = null;
                dvSanpham.DataSource = svspc.All();
                xoaform();

            }
            else
            { }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int masp = Int32.Parse(txtmasp.Text.Trim().ToString());
            string tensp = txttensp.Text.Trim().ToString();
            string mota = txtmota.Text.Trim().ToString();
            string kichthuoc = txtsize.Text.Trim().ToString();
            string mausac = txtmau.Text.Trim().ToString();
            string gia1 = txtgia.Text.Trim().ToString();
            decimal gia = decimal.Parse(gia1);

            string soluong = txtsoluong.Text.ToString();
            string madm = cboDanhmuc.SelectedValue.ToString().Trim();

            string hinhanh = Path.GetFileName(txtha.Text);
            int trangthai = Int32.Parse(cboTrangthai.SelectedValue.ToString());
            svsp.SuaSanPham(masp, masp, tensp, madm, gia, mota, kichthuoc, mausac, hinhanh,soluong, trangthai);
            MessageBox.Show("Sửa Thành Công");
            dvSanpham.DataSource = null;
            dvSanpham.DataSource = svspc.All();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tensp = txttensp.Text.ToString().Trim();
            string mota = txtmota.Text.ToString().Trim();
            string kichthuoc = txtsize.Text.ToString().Trim();
            string mausac = txtmau.Text.ToString().Trim();
            string gia1 = txtgia.Text.ToString().Trim();
            decimal gia = decimal.Parse(gia1);           
            string soluong = txtsoluong.Text.ToString().Trim();
            //string soluong = "0";
            string madm = cboDanhmuc.SelectedValue.ToString().Trim();
            string hinhanh = Path.GetFileName(txtha.Text);
            svsp.ThemSanPham(1, tensp, madm, gia, mota, kichthuoc, mausac, hinhanh, soluong);
            MessageBox.Show("Thêm Thành Công");
            
            dvSanpham.DataSource = null;
            dvSanpham.DataSource = svspc.All();
            xoaform();
        }
    }
}
