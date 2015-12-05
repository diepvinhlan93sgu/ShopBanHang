using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDatHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDatHang.svc or ServiceDatHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDatHang : IServiceDatHang
    {
        private ShopEntities db = new ShopEntities();
        private ShopEntities db1 = new ShopEntities();
        public List<DonHang> All()
        {
            return this.db.DonHangs.ToList();
        }

        public List<DonHang> DonHangTheoUser(string iduser)
        {
            var dhtu = (from p in db.DonHangs where p.IDUser.StartsWith(iduser) orderby p.MaDonHang descending select p);
            return dhtu.ToList();
            // return this.db.DonHangs.ToList();
        }



        public DonHang LayMaHD(string iduser)
        {

            DonHang dh = new DonHang();

            dh = ((from p in db.DonHangs where p.IDUser.StartsWith(iduser) orderby p.MaDonHang descending select p).Take(1)).Single();
            return dh;
        }

        public bool insertHD(string IDUser, DateTime Ngay, decimal TriGiaDH, string matrangthai)
        {
            try
            {
                DonHang dh = new DonHang();
                dh.IDUser = IDUser;
                dh.Ngay = Ngay;
                dh.TriGiaDH = TriGiaDH;
                dh.MaTrangThai = matrangthai;
                db.DonHangs.Add(dh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCTHD(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien)
        {
            try
            {
                SanPham sp = this.db1.SanPhams.First(p => p.MaSP == MaSP);
                CTDonHang dh = new CTDonHang();
                dh.MaDonHang = MaDonHang;
                dh.MaSP = MaSP;
                dh.SoLuong = SoLuong;
                //-----
                int c = int.Parse(dh.SoLuong.ToString());
                int b = 0;
                b = int.Parse(sp.SoLuong) - c;
                sp.SoLuong = b.ToString();
                //-----
                dh.Gia = Gia;
                dh.ThanhTien = ThanhTien;
                db1.SaveChanges();
                db.CTDonHangs.Add(dh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }




        public List<DonHang> TimTheoNgay(DateTime ngay)
        {
            //var dhn = (from p in db.DonHangs where (p.Ngay).ToString("yyyy/MM/dd") == ngay select p);
            // var dhn = (from p in db.DonHangs where (p.Ngay,"mm/dd/yyyy") == ngay select p);
            var dhn = (from p in db.DonHangs where p.Ngay.Value.Day == ngay.Day && p.Ngay.Value.Month == ngay.Month && p.Ngay.Value.Year == ngay.Year select p);
            //  var dhn = (from p in db.DonHangs where String.Format("{0}", String.Format("{0:dd-MM-yyyy}", p.Ngay)) == ngay select p);
            return dhn.ToList();
        }

        public bool LuuTrangThai(int MaDonHang, string matrangthai)
        {
            try
            {
                DonHang sp = db.DonHangs.First(p => p.MaDonHang == MaDonHang);
                sp.MaTrangThai = matrangthai;
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
