using MVCShop.Models;
using MVCShop.ServiceReferenceCTDonHangCustom;
using MVCShop.ServiceReferenceDatHang;
using MVCShop.ServiceReferenceSanPham;
using MVCShop.ServiceReferenceUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MVCShop.Controllers
{
    public class GioHangController : Controller
    {
        //
        // GET: /GioHang/
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        private ServiceDatHangClient svdh = new ServiceDatHangClient();
        private ServiceUserClient svuser = new ServiceUserClient();
        private ServiceCTDonHangCustomClient svctdhct = new ServiceCTDonHangCustomClient();
        public ActionResult Index()
        {
            try
            {
                int num = MVCShop.Models.MySession.GioHang.Count;
                if (num > 0)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "SanPham");
                }
            }
            catch
            {
                return RedirectToAction("Index", "SanPham");
            }

        }
        public ActionResult Menugiohang()
        {
            return View();
        }

        // them vao gio
        public ActionResult AddToCart(int id)
        {
            //Lưu các mã sản phẩm
            string ma = Session[MVCShop.Models.MySession.MaSanPham] + id.ToString();
            Session[MVCShop.Models.MySession.MaSanPham] = ma;

            //Số lượng sản phẩm có trong giỏ hàng
            int sl = 1 + Convert.ToInt32(Session[MVCShop.Models.MySession.TongSL]);
            Session[MVCShop.Models.MySession.TongSL] = sl.ToString();

            SanPham ctsp = svsp.ChiTietSP(id);
            //  var n  = svsp.ChiTietSP(id);
            var query1 = new Products();
            query1.MaSanPham = ctsp.MaSP;
            query1.TenSanPham = ctsp.TenSP;
            query1.Gia = decimal.Ceiling((decimal)ctsp.Gia + 0);
            query1.TongTien = decimal.Ceiling((decimal)ctsp.Gia + 0);
            query1.SoLuong = 1;


            List<Products> danhsach = new List<Products>();
            danhsach.Add(query1);


            try
            {
                bool flag = false;
                for (int i = 0; i < MySession.GioHang.Count; i++)
                {
                    if (MySession.GioHang[i].MaSanPham == danhsach[0].MaSanPham)
                    {
                        MySession.GioHang[i].SoLuong = MySession.GioHang[i].SoLuong + 1;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    foreach (var s in danhsach)
                    {
                        MySession.GioHang.Add(s);
                    }
                }
                MySession.TongTien = MySession.TongTien + Convert.ToDecimal(danhsach[0].TongTien.ToString());
            }
            catch
            {
                MySession.GioHang = danhsach;
                MySession.TongTien = Convert.ToDecimal(danhsach[0].TongTien.ToString());
            }

            return Redirect("../Index");
        }

        //Cập nhật số lượng sản phẩm trong giỏ
        [HttpPost]
        public ActionResult UpdateCart(FormCollection formCollection)
        {
            int sl = int.Parse(formCollection["USoLuong"]);
            int masp = int.Parse(formCollection["UMaSanPham"]);
            Session[MVCShop.Models.MySession.TongSL] = "0";
            //SanPham sol = db.SanPhams.First(p => p.MaSP == masp);
            //int Sol = int.Parse(sol.SoLuong.ToString());
            SanPham ctsp = svsp.ChiTietSP(masp);
            int Sol = int.Parse(ctsp.SoLuong.ToString());
            MySession.TongTien = 0;
            for (int i = 0; i < MySession.GioHang.Count; i++)
            {
                if (MySession.GioHang[i].MaSanPham == masp)
                {
                    if (sl < 1)
                    {
                        MySession.GioHang[i].SoLuong = 1;
                        Session[MVCShop.Models.MySession.TongSL] = ((Convert.ToInt32(Session[MVCShop.Models.MySession.TongSL]) + 1)).ToString();
                        MySession.GioHang[i].TongTien = MySession.GioHang[i].Gia;
                    }
                    else
                        if (sl < Sol)
                        {
                            MySession.GioHang[i].SoLuong = sl;
                            Session[MVCShop.Models.MySession.TongSL] = ((Convert.ToInt32(Session[MVCShop.Models.MySession.TongSL]) + sl)).ToString();
                            MySession.GioHang[i].TongTien = MySession.GioHang[i].Gia * sl;
                        }
                        else
                        {


                            return RedirectToAction("Index");

                        }
                }
                else
                {
                    Session[MVCShop.Models.MySession.TongSL] = ((Convert.ToInt32(Session[MVCShop.Models.MySession.TongSL]) + MySession.GioHang[i].SoLuong)).ToString();

                }
                MySession.TongTien = MySession.TongTien + MySession.GioHang[i].TongTien;
            }
            return RedirectToAction("Index");
        }

        //Xóa sản phẩm trong giỏ
        public ActionResult DeleteCart(int id)
        {
            Session[MVCShop.Models.MySession.TongSL] = "0";
            List<Products> lst = new List<Products>();
            int i = 0;
            MySession.TongTien = 0;
            foreach (var s in MySession.GioHang)
            {
                if (MySession.GioHang[i].MaSanPham != id)
                {
                    lst.Add(s);
                    MySession.TongTien = MySession.TongTien + (MySession.GioHang[i].Gia * MySession.GioHang[i].SoLuong);
                    Session[MVCShop.Models.MySession.TongSL] = (Convert.ToInt32(Session[MVCShop.Models.MySession.TongSL]) + MySession.GioHang[i].SoLuong).ToString();
                }
                i++;
            }
            MySession.GioHang = lst;
            if (MySession.GioHang.Count == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // chap nhan thanh toan
        string tongtien = "";
        public ActionResult Payment(FormCollection f)
        {



            string name = this.HttpContext.User.Identity.Name;
            svdh.insertHD(this.HttpContext.User.Identity.Name, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), decimal.Parse(Request.QueryString["tongtien"]), "0");
            //DonHang lhd = svdh.LayMaHD(name);// sua gia tri ngay nhap vo day ne
            DonHang ldh = svdh.LayMaHD(name);


            List<Products> lst = new List<Products>();
            int j = 0;
            foreach (var s in MySession.GioHang)
            {

                int ctmasp = int.Parse(MySession.GioHang[j].MaSanPham.ToString());

                svdh.insertCTHD(ldh.MaDonHang, ctmasp, int.Parse(MySession.GioHang[j].SoLuong.ToString()), decimal.Parse(MySession.GioHang[j].Gia.ToString()), decimal.Parse((MySession.GioHang[j].Gia * MySession.GioHang[j].SoLuong).ToString()));

                j++;

            }



            // return RedirectToAction("Index");
            return RedirectToAction("SendMailCart");

        }
        public ActionResult SendMailCart()
        {

            string name = HttpContext.User.Identity.Name;
            //User usr = db.Users.SingleOrDefault(p => p.IDUser == name);
            User usr = svuser.TimEDitUser(name);
            string Email = usr.Email.Trim();
            string hoten = usr.HoTenUser.Trim();
            string chuoi = "";


            chuoi += "Đơn đặt hàng của " + hoten + " tại PosShop " + "\n";
            int tongtien1 = 0;
            foreach (var item in MySession.GioHang)
            {
                chuoi += "Mã SP: " + item.MaSanPham + "\tTên SP: " + item.TenSanPham + "\t Giá SP: " + item.Gia + "\t" + "\t Số Lượng SP: " + item.SoLuong + "\t" + "\t Thành tiền: " + item.TongTien + "\n";
                tongtien1 += int.Parse(item.TongTien.ToString());
            }
            chuoi += "Tổng tiền:" + tongtien1 + "\n";
            chuoi += "Đơn đặt hàng của " + hoten + " tại PosShop  đã được xác nhận" + "\n";
            chuoi += "Chúng tôi sẽ giao hàng trong vòng 24h" + "\n";
            chuoi += "Trước khi giao hàng sẽ có nhân viên gọi điện trước 30p";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("secminh@gmail.com");
            msg.To.Add(Email);
            msg.Subject = "GIỎ HÀNG CỦA QUÝ KHÁCH TẠI PosShop";
            msg.Body = chuoi;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("secminh@gmail.com", "themoment");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            // smtp.UseDefaultCredentials = true;
            smtp.Send(msg);
            Session[MVCShop.Models.MySession.TongSL] = "0";

            MVCShop.Models.MySession.TongTien = 0;
            List<Products> lstd = new List<Products>();

            {

                lstd.Clear();
            }

            MySession.GioHang = lstd;
            return RedirectToAction("Index", "SanPham");
        }
        int pagesize = 10;
        public ActionResult LichSuGioHang(int page = 1)
        {
            string iduser = this.HttpContext.User.Identity.Name.ToString();
            //DonHang hoadon = db.DonHangs.SingleOrDefault(p => p.IDUser == iduser);
            // var hoadon = (from p in db.DonHangs where p.IDUser.StartsWith(iduser) orderby p.MaDonHang descending select p).ToList();
            var hoadon = svdh.DonHangTheoUser(iduser).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)hoadon.Count / pagesize);
            return View(hoadon.Skip((page - 1) * pagesize).Take(pagesize));
            //  return View(hoadon);
        }

        public ActionResult ChiTietDonHang()
        {
            List<ChiTietDonHang> lstd = new List<ChiTietDonHang>();
            {

                lstd.Clear();
            }

            MySession.ChiTietDonHang = lstd;


            //  int mahoadon = int.Parse(Request.QueryString["mahoadon"].ToString());
            string a = Request.QueryString["madonhang"].ToString();
            int mahoadon = Convert.ToInt32(a);
            /* var cthd = (from p in db.CTDonHangs
                         join q in db.SanPhams on p.MaSP equals q.MaSP
                         //   var sanpham =    (from p in db.SanPhams q in db.DanhMucSPs
                         where p.MaDonHang == mahoadon
                         select new ChiTietDonHang
                         {
                             MaSP = p.MaSP,
                             ID = p.ID,
                             MaDonHang = p.MaDonHang,
                             SoLuong = p.SoLuong,
                             TenSP = q.TenSP,
                             Gia = decimal.Ceiling((decimal)p.Gia + 0),
                             ThanhTien = decimal.Ceiling((decimal)p.ThanhTien + 0),

                         }).ToList();*/
            // CTDonHangCustom cthd = svdh.ChiTietDonHang(mahoadon);
            var cthd = svctdhct.ChiTietDonHang(mahoadon);
            List<ChiTietDonHang> danhsach = new List<ChiTietDonHang>();
            foreach (var item in cthd)
            {
                var query1 = new ChiTietDonHang();
                query1.MaSP = item.MaSP;
                query1.ID = item.ID;
                query1.MaDonHang = item.MaDonHang;
                query1.SoLuong = item.SoLuong;
                query1.TenSP = item.TenSP;
                query1.Gia = decimal.Ceiling((decimal)item.Gia + 0);
                query1.ThanhTien = decimal.Ceiling((decimal)item.ThanhTien + 0);
                danhsach.Add(query1);
            }
            //var query1 = new ChiTietDonHang();
            //query1.MaSP = cthd.MaSP;
            //query1.ID = cthd.ID;
            //query1.MaDonHang = cthd.MaDonHang;
            //query1.SoLuong = cthd.SoLuong;
            //query1.TenSP = cthd.TenSP;
            //query1.Gia = decimal.Ceiling((decimal)cthd.Gia + 0);
            //query1.ThanhTien = decimal.Ceiling((decimal)cthd.ThanhTien + 0);




            //-----------------

            try
            {
                /*  bool flag = false;
                  for (int i = 0; i < MySession.ChiTietHonHang.Count; i++)
                  {
                      if (MySession.ChiTietHonHang[i].ID == cthd[0].ID)
                      {
                          MySession.ChiTietHonHang[i].SoLuong = MySession.ChiTietHonHang[i].SoLuong + 1;
                          flag = true;
                      }
                  }
                  if (flag == false)*/
                //  {

                //-------------


                foreach (var s in danhsach)
                {
                    MySession.ChiTietDonHang.Add(s);
                }
                //  }

            }
            catch
            {
                MySession.ChiTietDonHang = danhsach;

            }

            //var sp = MySession.ASanPham.ToList();
            // ViewBag.TotalPages = Math.Ceiling((double)sp.Count / pagesize);
            //  return View(sp.Skip((page - 1) * pagesize).Take(pagesize));
            return View(MySession.ChiTietDonHang);


        }
	}
}