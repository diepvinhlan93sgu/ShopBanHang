using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShop.Models
{
    public class Products
    {
        public int? MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal? Gia { get; set; }
        public string HinhAnh { get; set; }
        public int? SoLuong { get; set; }
        public decimal? TongTien { get; set; }
    }
}