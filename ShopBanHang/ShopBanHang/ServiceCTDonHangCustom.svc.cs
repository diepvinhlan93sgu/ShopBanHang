using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCTDonHangCustom" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCTDonHangCustom.svc or ServiceCTDonHangCustom.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCTDonHangCustom : IServiceCTDonHangCustom
    {
        private ShopEntities db = new ShopEntities();
        public List<CTDonHangCustom> ChiTietDonHang(int madonhang)
        {
            var cthd = (from p in db.CTDonHangs
                        join q in db.SanPhams on p.MaSP equals q.MaSP
                        //   var sanpham =    (from p in db.SanPhams q in db.DanhMucSPs
                        where p.MaDonHang == madonhang

                        select new CTDonHangCustom
                        {
                            MaSP = p.MaSP,
                            ID = p.ID,
                            MaDonHang = p.MaDonHang,
                            SoLuong = p.SoLuong,
                            TenSP = q.TenSP,
                            Gia = decimal.Ceiling((decimal)p.Gia + 0),
                            ThanhTien = decimal.Ceiling((decimal)p.ThanhTien + 0)
                        }).ToList();

            return cthd;


        }
    }
}
