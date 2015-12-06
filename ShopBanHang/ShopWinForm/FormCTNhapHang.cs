using ShopWinForm.ServiceNhapHang;
using ShopWinForm.ServiceReferenceCTPhieuNhapCustom;
using ShopWinForm.ServiceReferenceDanhMucSP;
using ShopWinForm.ServiceReferenceDatHang;
using ShopWinForm.ServiceReferenceSanPham;
using ShopWinForm.ServiceSanPhamCustom;
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
    public partial class FormCTNhapHang : Form
    {
        int _mapn = FormQLNhapHang._mapn;
        DateTime _ngay = FormQLNhapHang._ngay;
        private ServiceNhapHangClient svnh = new ServiceNhapHangClient();
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        private ServiceSanPhamCustomClient svspc = new ServiceSanPhamCustomClient();
        private ServiceDatHangClient svdh = new ServiceDatHangClient();
        private ServiceCTPhieuNhapCustomClient svctpnc = new ServiceCTPhieuNhapCustomClient();
        

        public FormCTNhapHang()
        {
            InitializeComponent();
        }

        private void FormCTNhapHang_Load(object sender, EventArgs e)
        {
            if (_mapn == 0)
            {
                tabControl1.Visible = true;
                btnLuu.Visible = true;
                dvSanpham.AutoGenerateColumns = false;
                dvSanpham.DataSource = svspc.All();

                cboloaisp.DataSource = svdm.All();
                cboloaisp.DisplayMember = "TenDM";
                cboloaisp.ValueMember = "MaDM";
            }
            else
            {
                btnLuu.Visible = false;
                tabControl1.Visible = false;
                dvctnhaphang.AutoGenerateColumns = false;
                dvctnhaphang.DataSource = svctpnc.CTPhieuNhap(_mapn);
                dTNgayNhap.Value = _ngay;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _mapn = 0;
            this.Close();
            FormQLNhapHang qln = new FormQLNhapHang();
            qln.Show();
        }

        private void btnThemSPMoi_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSanPham sp = new FormSanPham();
            sp.Show();
        }

        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            cboloaisp.Text = "";
            cboTenSP.Text = "";
            txtSoLuong.Clear();
        }

        private void btnChonSanPham_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void cboloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madm = cboloaisp.SelectedValue.ToString().Trim();
            // svsp.SanPhamTheoLoai(madm);

            cboTenSP.DataSource = svsp.SanPhamTheoLoai(madm);
            cboTenSP.DisplayMember = "TenSP";
            cboTenSP.ValueMember = "MaSP";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            int idSP = cboTenSP.SelectedIndex;
            string tenSP = Convert.ToString(cboTenSP.Text);
            int soLuong = 0;
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng lớn hơn 0", "Thông báo");
                return;
            }
            else
            {
                soLuong = Convert.ToInt32(txtSoLuong.Text);
            }


            var query1 = new CTPhieuNhap();
            query1.TenSP = tenSP;
            query1.MaSP = idSP;
            query1.SoLuong = soLuong;



            List<CTPhieuNhap> danhsach = new List<CTPhieuNhap>();
            danhsach.Add(query1);

            try
            {
                bool flag = false;
                for (int i = 0; i < MySession.ChiTietPhieuNhap.Count; i++)
                {
                    if (MySession.ChiTietPhieuNhap[i].MaSP == danhsach[0].MaSP)
                    {
                        MySession.ChiTietPhieuNhap[i].SoLuong = MySession.ChiTietPhieuNhap[i].SoLuong + 1;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    foreach (var s in danhsach)
                    {
                        MySession.ChiTietPhieuNhap.Add(s);
                    }
                }

            }
            catch
            {
                MySession.ChiTietPhieuNhap = danhsach;

            }


            dvctnhaphang.DataSource = null;
            dvctnhaphang.AutoGenerateColumns = false;
            dvctnhaphang.DataSource = MySession.ChiTietPhieuNhap;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvctnhaphang.SelectedRows)
            {
                CTPhieuNhap ctpn = (CTPhieuNhap)row.DataBoundItem;
                int id = ctpn.MaSP;
                List<CTPhieuNhap> lst = new List<CTPhieuNhap>();
                int i = 0;

                foreach (var s in MySession.ChiTietPhieuNhap)
                {
                    if (MySession.ChiTietPhieuNhap[i].MaSP != id)
                    {
                        lst.Add(s);

                    }
                    i++;
                }
                MySession.ChiTietPhieuNhap = lst;

                dvctnhaphang.DataSource = null;
                dvctnhaphang.AutoGenerateColumns = false;
                dvctnhaphang.DataSource = MySession.ChiTietPhieuNhap;
            }
        }

        private void dvctnhaphang_SelectionChanged(object sender, EventArgs e)
        {
            if (dvctnhaphang.SelectedRows.Count > 0)
            {
                CTPhieuNhap sp = (CTPhieuNhap)dvctnhaphang.SelectedRows[0].DataBoundItem;
                cboloaisp.Text = sp.MaSP.ToString();
                cboTenSP.Text = sp.TenSP.ToString();
                txtSoLuong.Text = sp.SoLuong.ToString();
            }
        }

        private void dvSanpham_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            // SanPham dd = danhsach[e.RowIndex];
            int idSP = Int32.Parse(dvSanpham.Rows[e.RowIndex].Cells[0].Value.ToString());
            string tenSP = dvSanpham.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            string tenDM = dvSanpham.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();

            cboTenSP.Text = tenSP.ToString();
            cboloaisp.Text = tenDM.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MySession.ChiTietPhieuNhap.Count == 0)
                {
                    MessageBox.Show("Bạn chưa nhập chi tiết phiếu nhập", "Thông báo");
                    return;
                }
                DateTime ngay = dTNgayNhap.Value;
                svnh.ThemPN(ngay);
                // string _ngay = ngay.ToString("yyyy/MM/dd");
                //svnh.ThemPN(ngay);
                // svnh.ThemPN(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

                WFNhapHang lpn = svnh.LayMaPN();
                int j = 0;
                foreach (var s in MySession.ChiTietPhieuNhap)
                {

                    int ctmasp = int.Parse(MySession.ChiTietPhieuNhap[j].MaSP.ToString());

                    svnh.ThemCTPN(lpn.MaPN, ctmasp, int.Parse(MySession.ChiTietPhieuNhap[j].SoLuong.ToString()));

                    j++;

                }
                MessageBox.Show("Thêm Thành Công");
            }
            catch
            {
            }
        }
    }
}
