using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWinForm
{
    class MySession
    {
        public static string MaSanPham
        {
            get { return "0"; }
        }

        public static string TongSL
        {
            get { return "1"; }
        }

        public static List<CTPhieuNhap> ChiTietPhieuNhap { get; set; }
    }
}
