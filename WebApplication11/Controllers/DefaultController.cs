using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbAcunmedyaproject1Entities1 db = new DbAcunmedyaproject1Entities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values =db.TblTestimonial.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialServices ()
        {
            var values = db.TblServices.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            var values =db.TblContact.ToList();
            return PartialView(values);
        }

        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage (TblMessage message)
        {
            db.TblMessage.Add(message);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialAbout()
        {
            var values =db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values =db.TblSkill.ToList();
            return PartialView(values);
        }
      
        public PartialViewResult PartialProject()
        {
            var values =db.TblProject.ToList();
            return PartialView(values);
        }
        
        public PartialViewResult PartialEducation()
        {
            var values =db.TblEducation.ToList();
            return PartialView(values);
        }
    }
}