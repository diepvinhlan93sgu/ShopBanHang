using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceNhapHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceNhapHang.svc or ServiceNhapHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceNhapHang : IServiceNhapHang
    {
        private ShopEntities db = new ShopEntities();
        private ShopEntities db1 = new ShopEntities();

        public List<WFNhapHang> All()
        {
            return this.db.WFNhapHangs.ToList();
        }

        public List<WFCTPhieuNhap> CTPhieuNhap(int mapn)
        {
            var ctpn = (from p in db.WFCTPhieuNhaps where p.MaPN == mapn select p);
            return ctpn.ToList();
        }
        public bool XoaPN(int mapn)
        {
            try
            {
                WFNhapHang pn = db.WFNhapHangs.SingleOrDefault(p => p.MaPN == mapn);
                db.WFNhapHangs.Remove(pn);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemPN(DateTime ngay)
        {
            try
            {
                WFNhapHang pn = new WFNhapHang();

                pn.NgayNhap = ngay;

                db.WFNhapHangs.Add(pn);
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ThemCTPN(int mapn, int masp, int soluong)
        {
            try
            {
                SanPham sp = this.db1.SanPhams.First(p => p.MaSP == masp);
                WFCTPhieuNhap pn = new WFCTPhieuNhap();
                pn.MaPN = mapn;
                pn.MaSP = masp;
                pn.SoLuong = soluong;
                //-----
                int c = int.Parse(pn.SoLuong.ToString());
                int b = 0;
                b = int.Parse(sp.SoLuong) + c;
                sp.SoLuong = b.ToString();
                //-----
                db1.SaveChanges();
                db.WFCTPhieuNhaps.Add(pn);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public WFNhapHang LayMaPN()
        {

            WFNhapHang pn = new WFNhapHang();

            pn = ((from p in db.WFNhapHangs orderby p.MaPN descending select p).Take(1)).Single();
            return pn;
        }
        

    }
}
