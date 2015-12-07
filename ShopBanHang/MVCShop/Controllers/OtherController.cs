using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCShop.Controllers
{
    public class OtherController : Controller
    {
        //
        // GET: /Other/


        public ActionResult BaoHanh()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult HDMuaHang()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }
	}
}