using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPham" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPham.svc or ServiceSanPham.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPham : IServiceSanPham
    {
        private ShopEntities db = new ShopEntities();
        public List<SanPham> All()
        {
            // return this.db.SanPhams.ToList();
            var sptl = (from p in db.SanPhams where p.TrangThai == 0 select p);
            return sptl.ToList();
        }

        public SanPham ChiTietSP(int masp)
        {
            return this.db.SanPhams.Single(sp => sp.MaSP == masp);
        }

        public List<SanPham> SanPhamTheoLoai(string loai)
        {
            var sptl = (from p in db.SanPhams where p.MaDM.StartsWith(loai) && p.TrangThai == 0 select p);
            return sptl.ToList();
        }

        public List<SanPham> TimKiem(string id)
        {
            var product = (from p in db.SanPhams select p).ToList();
            product = product.Where(a => a.TenSP.ToLower().Contains(id)).ToList();
            return product;
        }

        public bool XoaSanPham(int masp)
        {
            try
            {
                SanPham sp = db.SanPhams.SingleOrDefault(p => p.MaSP == masp);
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaSanPham(int maspht, int masp, string tensp, string madm, decimal gia, string mota, string kichthuoc, string mausac, string hinhanh, string soluong, int trangthai)
        {

            try
            {
                SanPham sp = db.SanPhams.First(p => p.MaSP == maspht);
                sp.TenSP = tensp;
                sp.MaDM = madm;
                sp.Gia = gia;
                sp.MoTa = mota;
                sp.KichThuoc = kichthuoc;

                sp.MauSac = mausac;

                sp.HinhAnh = hinhanh;
                sp.SoLuong = soluong;
                sp.TrangThai = trangthai;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemSanPham(int masp, string tensp, string madm, decimal gia, string mota, string kichthuoc, string mausac, string hinhanh, string soluong)
        {

            try
            {
                SanPham sp = new SanPham();
                sp.TenSP = tensp;
                sp.MaDM = madm;
                sp.Gia = gia;
                sp.MoTa = mota;
                sp.KichThuoc = kichthuoc;
                sp.MauSac = mausac;
                sp.HinhAnh = hinhanh;
                sp.SoLuong = soluong;
                sp.TrangThai = 0;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
