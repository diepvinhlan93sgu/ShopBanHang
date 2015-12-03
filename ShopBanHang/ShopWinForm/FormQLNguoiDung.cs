using ShopWinForm.ServiceReferenceUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForm
{
    public partial class FormQLNguoiDung : Form
    {
        private ServiceUserClient svuser = new ServiceUserClient();

        public FormQLNguoiDung()
        {
            InitializeComponent();
        }

        private void FormQLNguoiDung_Load(object sender, EventArgs e)
        {
            btnxoa.Visible = false;
            btnsua.Visible = false;
            dvUser.AutoGenerateColumns = false;
            dvUser.DataSource = svuser.All();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            btnxoa.Visible = false;
            btnsua.Visible = false;
            btnthem.Visible = true;
            txtUser.ReadOnly = false;
            txtUser.Clear();
            txtPass.Clear();
            txtFullname.Clear();
            txtemail.Clear();
            txtDiaChi.Clear();
            txtsdt.Clear();
            txtngay.Clear();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dvUser.SelectedRows.Count > 0)
            {
                btnxoa.Visible = true;
                btnsua.Visible = true;
                btnthem.Visible = false;
                txtUser.ReadOnly = true;

                User us = (User)dvUser.SelectedRows[0].DataBoundItem;
                txtUser.Text = us.IDUser;
                txtPass.Text = us.PassUser;
                txtFullname.Text = us.HoTenUser;
                txtemail.Text = us.Email;
                txtDiaChi.Text = us.DiaChi;
                txtsdt.Text = us.SoDienThoai;
                txtngay.Text = us.Ngaysinh;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này !!!", "Sure?", MessageBoxButtons.YesNo)
          == DialogResult.Yes)
            {
                string id = txtUser.Text.ToString().Trim();
                svuser.XoaUser(id);
                dvUser.DataSource = null;
                dvUser.DataSource = svuser.All();
            }
            else
            { }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            string fullname = txtFullname.Text.ToString();
            string email = txtemail.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string sdt = txtsdt.Text.ToString();
            string ngaysinh = txtngay.Text.ToString();
            int quyen = 1;
            svuser.AddUser(user, pass, fullname, email, diachi, sdt, ngaysinh, quyen);

            dvUser.DataSource = null;
            dvUser.DataSource = svuser.All();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            string fullname = txtFullname.Text.ToString();
            string email = txtemail.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string sdt = txtsdt.Text.ToString();
            string ngaysinh = txtngay.Text.ToString();
            svuser.EditUser(user, user, pass, fullname, email, diachi, sdt, ngaysinh);
            MessageBox.Show("Sửa Thành Công");
            dvUser.DataSource = null;
            dvUser.DataSource = svuser.All();
        }
    }
}
