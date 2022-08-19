using BusinessLayer.Concrete;
using DataAcceessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKCB_Law_Office_Web.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        tblMessageManager mm = new tblMessageManager(new EfMessagesDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetMessageList()
        {
            int id = (int)Session["perId"];
            //ViewBag.c = id;
            var messageValues = mm.GetListInBox(id);
            return View(messageValues);
        }
        public ActionResult GetSendMessageList()
        {
            int id = (int)Session["perId"];
            var messageValues = mm.GetListSendBox(id);
            return View(messageValues);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var messageDetails = mm.GetById(id);
            return View(messageDetails);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(tblMessage p)
        {
            p.MessageDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
            p.SenderId = (int)Session["perId"];
            mm.MessageAdd(p);
            return RedirectToAction("GetMessageList");
        }
    }
}