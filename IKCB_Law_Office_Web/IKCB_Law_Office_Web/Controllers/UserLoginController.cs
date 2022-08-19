using DataAcceessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IKCB_Law_Office_Web.Controllers
{
    public class UserLoginController : Controller
    {
        

        // GET: UserLogin
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tblPersonel p)
        {
            Context c = new Context();
            var userinfo = c.tblPersonels.FirstOrDefault(x => x.perAdiSoyadi == p.perAdiSoyadi && x.perSifre == p.perSifre);
            if (userinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.perAdiSoyadi, false);
                Session["perId"] = userinfo.perId;
                Session["perAdiSoyadi"] = userinfo.perAdiSoyadi;
                Session["perProfilFoto"] = userinfo.perProfilFoto;
                return RedirectToAction("GetFilesList", "TblDosyalar");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}