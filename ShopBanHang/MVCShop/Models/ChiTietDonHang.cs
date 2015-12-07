using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShop.Models
{
    public class ChiTietDonHang
    {
        public int? MaSP { get; set; }
        public int? ID { get; set; }
        public int? MaDonHang { get; set; }
        public int? SoLuong { get; set; }
        public string TenSP { get; set; }
        public decimal? Gia { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}