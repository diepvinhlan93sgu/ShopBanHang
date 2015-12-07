using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShop.Models
{
    public class MySession1
    {
        public static string MaSanPham
        {
            get { return "4"; }
        }
        public static string TongSL
        {
            get { return "5"; }
        }
        public static string Email
        {
            get { return "6"; }
        }

        public static decimal? TongTien { get; set; }

        public static List<Products1> GioHang { get; set; }
        public static List<Products1> GioHang1 { get; set; }
    }
}