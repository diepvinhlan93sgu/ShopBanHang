using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDanhMucSP" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDanhMucSP.svc or ServiceDanhMucSP.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDanhMucSP : IServiceDanhMucSP
    {
        private ShopEntities db = new ShopEntities();

        public List<DanhMucSP> All()
        {
            return this.db.DanhMucSPs.ToList();
        }


        public bool ThemDanhmuc(string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = new DanhMucSP();
                dm.MaDM = madm;
                dm.TenDM = tendm;
                db.DanhMucSPs.Add(dm);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDanhmuc(string dmht, string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.First(p => p.MaDM.Trim() == dmht);
                dm.MaDM = madm;
                dm.TenDM = tendm;      
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDanhmuc(string madm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.SingleOrDefault(p => p.MaDM.Contains(madm));
                db.DanhMucSPs.Remove(dm);
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
