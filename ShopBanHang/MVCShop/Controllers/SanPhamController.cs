using MVCShop.ServiceReferenceDanhMucSP;
using MVCShop.ServiceReferenceSanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCShop.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        int pagesize = 10;
        public ActionResult Index(int page = 1)
        {
            var sanpham = svsp.All().ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
            return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));
        }
        public ActionResult DanhMucSP()
        {
            var dmsp = svdm.All();

            return PartialView(dmsp);
        }
        public ActionResult ChiTietSP()
        {
            string a = Request.QueryString["Masp"];
            int b = Convert.ToInt32(a);
            SanPham ctsp = svsp.ChiTietSP(b);

            return PartialView(ctsp);
        }
        public ActionResult SanPhamTheoLoai(int page = 1)
        {
            string a = Request.QueryString["loai"];
            //var sanpham = (from p in db.SanPhams where p.MaDM.StartsWith(a) select p).ToList();
            var sanpham = svsp.SanPhamTheoLoai(a).ToList();

            // ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / 12);
            //ViewBag.maloai = a;
            // return View(sanpham);
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / 12);
            ViewBag.maloai = a;
            return View(sanpham.Skip((page - 1) * 12).Take(12));
        }
        string id = "";
        public ActionResult KQTimKiem(FormCollection f, int page = 1)
        {
            id = f["chuoitk"].ToString();
            //var product = (from p in db.SanPhams select p).ToList();
            var product = svsp.TimKiem(id).ToList();
            ViewBag.Tensp = id;
            /* id = id.ToLower();
             if (!String.IsNullOrEmpty(id))
             {
                 product = product.Where(a => a.TenSP.ToLower().Contains(id)).ToList();
             }*/
            ViewBag.KhongTimThay = "Không tìm thấy các sản phẩm thỏa điều kiện!";
            //  ViewBag.TotalPages = Math.Ceiling((double)product.Count / pagesize);
            // return View(product);
            ViewBag.TotalPages = Math.Ceiling((double)product.Count / pagesize);
            return View(product.Skip((page - 1) * pagesize).Take(pagesize));

        }
	}
}