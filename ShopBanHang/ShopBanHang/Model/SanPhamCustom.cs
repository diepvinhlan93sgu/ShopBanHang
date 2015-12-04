using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBanHang
{
    public class SanPhamCustom
    {
        public string TenDM { get; set; }

        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaDM { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public string MoTa { get; set; }
        public string KichThuoc { get; set; }
        public string MauSac { get; set; }
        public string HinhAnh { get; set; }
        public string SoLuong { get; set; }
        public int? TrangThai { get; set; }
    }
}