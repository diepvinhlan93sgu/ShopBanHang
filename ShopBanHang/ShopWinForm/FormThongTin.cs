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
    public partial class FormThongTin : Form
    {
        public FormThongTin()
        {
            InitializeComponent();
        }

        private void btnQuayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
