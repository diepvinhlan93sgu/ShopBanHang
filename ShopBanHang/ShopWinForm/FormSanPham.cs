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
            dvSanpham.AutoGenerateColumns = false;
            dvSanpham.DataSource = svspc.All();
            cboDanhmuc.DataSource = svdm.All();
            cboDanhmuc.DisplayMember = "TenDM";
            cboDanhmuc.ValueMember = "MaDM";
        }

        private void dvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dvSanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (dvSanpham.SelectedRows.Count > 0)
            {

                btnsua.Visible = true;

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
                    string des = @"../../../MVCKLShop/Content/ImageSP/" + xxx[xxx.Length - 1];
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
    }
}
