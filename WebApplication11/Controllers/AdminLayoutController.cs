using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication11.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        //1.adım controller oluşturma
        //2.adım
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()

        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}