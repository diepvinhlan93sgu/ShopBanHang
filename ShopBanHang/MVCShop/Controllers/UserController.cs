using MVCShop.Models;
using MVCShop.ServiceReferenceUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCShop.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private ServiceUserClient svuser = new ServiceUserClient();
        public ActionResult DangNhap()
        {

            return View();


        }
        //login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f, string returnUrl)
        {
            //   if (ModelState.IsValid)
            //  {
            // using (KLShopEntities7 entities = new KLShopEntities7())
            //  {
            string username = f["user"];
            string password = f["pass"];
            //  svuser.Login(username, password);

            // bool userValid = entities.Users.Any(user => user.IDUser == username && user.PassUser == password);
            // User tìm trong database
            //----------------------------------------
            bool userVaild = svuser.Login(username, password);
            if (userVaild)
            {
                Session["User"] = username;
                /*  User usr = db.Users.First(p => p.IDUser.Trim() == username);
                  string quye = usr.Quyen.Value.ToString();

                  System.Web.HttpContext.Current.Session["Quyen"] = quye;*/
                // quyen1 = Session["User"].ToString();
                // var sanpham = (from p in db.Users where p.IDUser.StartsWith(username) select p).ToList();

                FormsAuthentication.SetAuthCookie(username, true);


                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    ViewBag.Err = "<script language=javascript>alert('Sai thông tin đăng nhập!');</script>";
                    return RedirectToAction("Index", "SanPham");
                }
            }
            else
            {
                ViewBag.Error = "<script language=javascript>alert('Tên đăng nhập hoặc mật khẩu không đúng');</script>";
                ViewBag.Err = "<script language=javascript>alert('Sai thông tin đăng nhập!');</script>";
                return RedirectToAction("Index", "SanPham");

            }
            //-------------------------------------------
            // }
            // }
            return RedirectToAction("Index", "SanPham");
            // return View(f);
        }


        // Edit User
        public ActionResult EditUser()
        {
            // User user = db.Users.Single(p => p.IDUser.Trim() == HttpContext.User.Identity.Name);
            User user = svuser.TimEDitUser(HttpContext.User.Identity.Name);
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {

            /* User usr = db.Users.First(p => p.IDUser.Trim() == HttpContext.User.Identity.Name);
             // User usr = new User();
             usr.IDUser = f["User"];
             usr.PassUser = f["Pass"];
             usr.HoTenUser = f["Fullname"];
             usr.Email = f["Email"];
             usr.DiaChi = f["DiaChi"];
             string s = f["Dienthoai"];
             decimal d = decimal.Parse(s);
             usr.SoDienThoai = f["Dienthoai"];

             usr.Ngaysinh = f["Ngaysinh"]; ;
             //  int a = usr.Quyen;
             //   usr.Quyen = a;
             if (ModelState.IsValid)
             {

                 UpdateModel(usr);
                 //db.Users.Attach(usr);
                 //int result = db.Database.ExecuteSqlCommand(sql, parameters);
                 //  db.ObjectStateManager.ChangeObjectState(usr, System.Data.EntityState.Modified);
                 // ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.(usr, System.Data.EntityState.Modified);
                 db.SaveChanges();
             }*/
            svuser.EditUser(HttpContext.User.Identity.Name, f["User"], f["Pass"], f["Fullname"], f["Email"], f["DiaChi"], f["Dienthoai"], f["Ngaysinh"]);
            return RedirectToAction("Index", "SanPham");
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKyUser(FormCollection f)
        {
            /*  User usr = new User();
              usr.IDUser = f["User"].ToString();
              usr.PassUser = f["Pass"].ToString();
              usr.HoTenUser = f["Fullname"].ToString();
              usr.Email = f["Email"].ToString();
              usr.DiaChi = f["DiaChi"].ToString();
              // string s =;
              // decimal d = decimal.Parse(s);
              usr.SoDienThoai = f["Dienthoai"].ToString();

              usr.Ngaysinh = f["Ngaysinh"].ToString();
              int a = 1;
              usr.Quyen = a;
              if (ModelState.IsValid)*/
            // {
            //  using (KLShopEntities7 entities = new KLShopEntities7())
            // {
            //-----------------------------------------
            /*  string name = f["User"];
             // bool userInValid = entities.Users.Any(user => user.IDUser == name);
              bool userInValid = svuser.KTraUser(name);
              if (userInValid)
              {

                  //ViewBag.Error = "<script language=javascript>alert('Đăng kí không thành công Ten đăng nhập bị trùng');</script>";
                  ViewBag.Mess = "Tên đăng nhập đã tồn tại!";
              }
              else
              {

                  //User us = db.Users.Find(name);
                  //  db.Users.Remove(us);

                  //ViewBag.success = "<script language=javascript>alert('Đăng kí thành công!');</script>";
                 svuser.AddUser(f["User"], f["Pass"], f["Fullname"], f["Email"], f["DiaChi"], f["Dienthoai"], f["Ngaysinh"]);
                 // db.Users.Add(usr);
                 // db.SaveChanges();
                  return RedirectToAction("Index", "SanPham");

              }*/
            //---------------------------------
            //  }

            // }
            // ViewBag.ThongTinUsr = usr;
            //return View();
            svuser.AddUser(f["User"], f["Pass"], f["Fullname"], f["Email"], f["DiaChi"], f["Dienthoai"], f["Ngaysinh"],0);
            return RedirectToAction("Index", "SanPham");
        }

        public ActionResult LogOff()
        {// vai code, noi chung no kiem tra dc, ma sao html bi gi ak. roi hieu, do m luc log out chua cho session == null

            //  Session.Abandon();
            Session[MVCShop.Models.MySession.TongSL] = "0";

            MVCShop.Models.MySession.TongTien = 0;
            List<Products> lst = new List<Products>();

            lst.Clear();

            MySession.GioHang = lst;
            List<Products1> lst1 = new List<Products1>();

            lst1.Clear();

            MySession1.GioHang = lst1;

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "SanPham");// trang nay co goi lai cai action kia k?action hien cau chao admin ak ko ko, phai goi lai, no moi kiem tra sesion dc ==
        }
	}
}