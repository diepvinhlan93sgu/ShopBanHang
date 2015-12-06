using ShopWinForm.ServiceCTDonHangCustom;
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
    public partial class FormCTDonHang : Form
    {
        int _madonhang = FormQLDonHang._madonhang;
        string _matrangthai = FormQLDonHang._matrangthai;
        string _user = FormQLDonHang._user;
        decimal _trigiahd = FormQLDonHang._tongtien;
        DateTime _ngay = FormQLDonHang._ngay;
        private ServiceUserClient svuser = new ServiceUserClient();
        private ServiceCTDonHangCustomClient svdhc = new ServiceCTDonHangCustomClient();
        public FormCTDonHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTDonHang_Load(object sender, EventArgs e)
        {
            lbTriGia.Text = _trigiahd.ToString();
            User us = svuser.TimEDitUser(_user);
            lbDiaChi.Text = us.DiaChi.ToString();
            lbSDT.Text = us.SoDienThoai.ToString();
            lbTenKH.Text = us.HoTenUser.ToString();
            lbNgay.Text = _ngay.ToString();

            dvCTDonhang.AutoGenerateColumns = false;
            dvCTDonhang.DataSource = svdhc.ChiTietDonHang(_madonhang);


        }
    }
}
