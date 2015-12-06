using ShopWinForm.ServiceNhapHang;
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
    public partial class FormQLNhapHang : Form
    {
        private ServiceNhapHangClient svnh = new ServiceNhapHangClient();
        List<WFNhapHang> listphieunhap = new List<WFNhapHang>();
        public static int _mapn;
        public static DateTime _ngay;
        public FormQLNhapHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLNhapHang_Load(object sender, EventArgs e)
        {
            listphieunhap = svnh.All().ToList();
            dvPhieunhap.AutoGenerateColumns = false;
            dvPhieunhap.DataSource = listphieunhap;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.Close();
            _mapn = 0;
            FormCTNhapHang ctnh = new FormCTNhapHang();
            ctnh.Show();
        }

        private void dvPhieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvPhieunhap.Columns["col_xoaPN"].Index)
            {
                // int pn = dvPhieunhap.datakeys Rows[e.RowIndex];
                int pn = Int32.Parse(dvPhieunhap.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không!", "Lưu ý", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        svnh.XoaPN(pn);
                        //pn.Delete();
                        dvPhieunhap.DataSource = null;
                        dvPhieunhap.DataSource = svnh.All();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không xóa được: " + ex.Message, "Loi");
                    }
                }
            }
            else if
                (e.ColumnIndex == dvPhieunhap.Columns["col_xemChiTiet"].Index)
            {
                int pn = Int32.Parse(dvPhieunhap.Rows[e.RowIndex].Cells[0].Value.ToString());
                DateTime pn1 = DateTime.Parse(dvPhieunhap.Rows[e.RowIndex].Cells[1].Value.ToString());
                _mapn = pn;
                _ngay = pn1;
                FormCTNhapHang frm = new FormCTNhapHang();

                this.Close();
                frm.Show();
            }
        }
    }
}
