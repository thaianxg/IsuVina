using IsuVina.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IsuVina.Controllers
{
    public class HomeController : Controller
    {
        IsuVinaEntities1 db = new IsuVinaEntities1();
        [HttpGet]
        public ActionResult Index(string id)
        {
            //var lang = Request.QueryString["id"];
            ListCommon cm = new ListCommon();
            cm.lstConstruction = db.Products.ToList();
            cm.lstRecentProduct = db.Products.ToList();
            //Session["lang"] = lang;
            //ViewBag["lang"] = lang;
            if (id == null)
                id = "en";
            ViewBag.lang = id;
            return View(cm);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Product()
        {
            var list = db.Products.ToList();
            return View(list);
        }
        public ActionResult Category(int? Id)
        {
            var list = db.Products.ToList();
            return View(list);
        }
        public ActionResult Login()
        {
            var list = db.Products.ToList();
            return View(list);
        }

        public ActionResult Product_detail(int? Id)
        {
               var product = db.Products.Find(Id);
                ListProductDetail lstProductDetail = new ListProductDetail();
            lstProductDetail.product = product;
            lstProductDetail.lstproduct = db.Products.ToList();
            return View(lstProductDetail);
        }
        public ActionResult CartList()
        {
            return View();
        }
        public ActionResult MyAccount()
        {
            return View();
        }
        public ActionResult _Construction(int PageNo = 0)
        {
            var list = db.Products.ToList();
           return PartialView(list);
        }
        public ActionResult ModalAdmin()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

     
    }
}