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

namespace ShopWinForm
{
    public partial class FormDanhMuc : Form
    {
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            dvDanhmuc.AutoGenerateColumns = false;
            dvDanhmuc.DataSource = svdm.All();
        }
        private void dvDanhmuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dvDanhmuc.SelectedRows.Count > 0)
            {

                DanhMucSP dm = (DanhMucSP)dvDanhmuc.SelectedRows[0].DataBoundItem;
                txtmadm.Text = dm.MaDM.ToString();
                txttendm.Text = dm.TenDM.ToString();
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madm = txtmadm.Text.ToString();
            string tendm = txttendm.Text.ToString();
            svdm.ThemDanhmuc(madm, tendm);

            dvDanhmuc.DataSource = null;
            dvDanhmuc.DataSource = svdm.All();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madm = txtmadm.Text.ToString();
            string tendm = txttendm.Text.ToString();

            svdm.SuaDanhmuc(madm, madm, tendm);
            MessageBox.Show("Sửa Thành Công");
            dvDanhmuc.DataSource = null;
            dvDanhmuc.DataSource = svdm.All();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này !!!", "Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string madm = txtmadm.Text.ToString().Trim();
                svdm.XoaDanhmuc(madm);
                dvDanhmuc.DataSource = null;
                dvDanhmuc.DataSource = svdm.All();
                xoaform();
            }
            else
            { }
        }

        private void btnxf_Click(object sender, EventArgs e)
        {
            btnxoa.Visible = false;
            btnsua.Visible = false;
            btnthem.Visible = true;
            txtmadm.ReadOnly = false;
            xoaform();
        }
        private void xoaform()
        {
           
            txtmadm.Clear();
            txttendm.Clear();
        }

    }
}
