using ShopWinForm.ServiceReferenceDatHang;
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
    public partial class FormQLDonHang : Form
    {
        private ServiceDatHangClient svdh = new ServiceDatHangClient();
        public static int _madonhang = 0;
        public static string _matrangthai = "";
        public static string _user = "";
        public static decimal _tongtien = 0;
        public static DateTime _ngay;
        public FormQLDonHang()
        {
            InitializeComponent();
        }

        private void FormQLDonHang_Load(object sender, EventArgs e)
        {
            dvDonhang.AutoGenerateColumns = false;
            dvDonhang.DataSource = svdh.All();

            var item = new[]
           {
                new { Text = "Chưa Giao", Value = "0" },
                new { Text = "Đã Giao", Value = "1" },

           };
            CboTrangthai.DataSource = item;
            CboTrangthai.DisplayMember = "Text";
            CboTrangthai.ValueMember = "value";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dvDonhang.AutoGenerateColumns = false;
            dvDonhang.DataSource = svdh.All();
        }

        private void dvDonhang_SelectionChanged(object sender, EventArgs e)
        {
            if (dvDonhang.SelectedRows.Count > 0)
            {
                DonHang dh = (DonHang)dvDonhang.SelectedRows[0].DataBoundItem;
                string abc = dh.MaTrangThai.ToString();
                txtiduser.Text = dh.IDUser.ToString();
                txtmadonhang.Text = dh.MaDonHang.ToString();
                CboTrangthai.SelectedValue = abc;
                _madonhang = dh.MaDonHang;
                _matrangthai = dh.MaTrangThai.ToString();
                _user = dh.IDUser.ToString();
                _tongtien = decimal.Parse(dh.TriGiaDH.ToString());
                _ngay = DateTime.Parse(dh.Ngay.ToString());
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime str = dtNgay.Value;
            // DateTime str = new DateTime(dtNgay.Value.Year, dtNgay.Value.Month, dtNgay.Value.Day);
            //string _ngay = str.ToString("MM/dd/yyyy");
            string a = DateTime.Now.ToShortDateString();
            /*DateTime a = DateTime.Now;
             string b = string.Format("{0:yyyy/mm/dd}", a);
             string _ngay = str.ToString("yyyy/MM/dd");*/
            //svdh.TimTheoNgay(str);
            //da
            dvDonhang.DataSource = null;
            dvDonhang.AutoGenerateColumns = false;
            dvDonhang.DataSource = svdh.TimTheoNgay(str);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mdh = Int32.Parse(txtmadonhang.Text.ToString());
            string matrangthai = CboTrangthai.SelectedValue.ToString().Trim();
            svdh.LuuTrangThai(mdh, matrangthai);
            MessageBox.Show("Sửa Thành Công");
            dvDonhang.DataSource = null;
            dvDonhang.DataSource = svdh.All();
        }

        private void btnCtDonHang_Click(object sender, EventArgs e)
        {
            if (dvDonhang.SelectedRows.Count > 0)
            {
                FormCTDonHang frm = new FormCTDonHang();
                frm.Show();
            }
            else
                MessageBox.Show("Bạn chưa chọn phiếu nhập cần xem", "Thông báo");
        }
    }
}
