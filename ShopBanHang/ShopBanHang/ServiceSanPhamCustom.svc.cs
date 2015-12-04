using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPhamCustom" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPhamCustom.svc or ServiceSanPhamCustom.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPhamCustom : IServiceSanPhamCustom
    {
        private ShopEntities db = new ShopEntities();
        public List<SanPhamCustom> All()
        {
            var ctsp = (from p in db.SanPhams
                        join q in db.DanhMucSPs on p.MaDM equals q.MaDM
                        

                        select new SanPhamCustom
                        {
                            MaSP = p.MaSP,
                            TenSP = p.TenSP,
                            SoLuong = p.SoLuong,
                            Gia = decimal.Ceiling((decimal)p.Gia + 0),
                            MaDM = p.MaDM,
                            TenDM = q.TenDM,
                            MoTa = p.MoTa,
                            KichThuoc = p.KichThuoc,
                            MauSac = p.MauSac,
                            HinhAnh= p.HinhAnh,
                            TrangThai = p.TrangThai,
                           
                        }).ToList();

            return ctsp;
        }
    }
}
