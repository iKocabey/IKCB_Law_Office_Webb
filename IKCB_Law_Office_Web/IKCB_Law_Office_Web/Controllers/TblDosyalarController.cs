using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcceessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKCB_Law_Office_Web.Controllers
{
    public class TblDosyalarController : Controller
    {
        // GET: TblDosyalar
        tblDosyalarManager dm = new tblDosyalarManager(new EfDosyalarDal());
        tblPersonelManager pm = new tblPersonelManager(new EfPersonelDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetFilesList(string p)
        {
            int id = (int)Session["perId"];
            p = (string)Session["perAdiSoyadi"];
            string x = (string)Session["perProfilFoto"];
            ViewBag.d = p;
            ViewBag.a = x;
            ViewBag.q = id;
            var fileValues = dm.GetlistByUser(id);
            return View(fileValues);
        }
        [HttpGet]
        public ActionResult AddFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFile(tblDosyalar p)
        {
            // return dm.
            TblDosyalarValidator dv = new TblDosyalarValidator();
            dm.FileAdd(p);
            return RedirectToAction("GetFilesList");
        }


        [HttpGet]
        public ActionResult AddCaseFile()
        {
            List<SelectListItem> valuePersonel = (from x in pm.GetList()//Eşittirin yanındaki yapı entity LinQ sorgusudur
                                                  select new SelectListItem
                                                  {
                                                      Text = x.perAdiSoyadi,
                                                      Value = x.perId.ToString()
                                                  }).ToList();
            ViewBag.a = valuePersonel;
            return View();
        }
        [HttpPost]
        public ActionResult AddCaseFile(tblDosyalar p)
        {
            //Burada dava dosyaları ekliyoruz.
            p.perId = (int)Session["perId"];
            p.dosyaDurum = "Açık";
            p.davaDurum = "Belli değil";
            dm.FileAdd(p);
            return RedirectToAction("GetFilesList");
        }
        
        public ActionResult DeleteFile(int id)
        {
            var filevalue = dm.GetById(id);
            dm.FileDelete(filevalue);
            return RedirectToAction("GetFilesList");
        }
        [HttpGet]
        public ActionResult UpdateFile(int id)
        {
            var filevalue = dm.GetById(id);
            return View(filevalue);
        }
        [HttpPost]
        public ActionResult UpdateFile(tblDosyalar p)
        {
            dm.FileUpdate(p);
            return RedirectToAction("GetFilesList");
        }
    }
}