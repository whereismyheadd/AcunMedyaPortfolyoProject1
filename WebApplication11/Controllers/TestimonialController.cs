using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;
namespace WebApplication11.Controllers
{
    public class TestimonialController:Controller
    {
        DbAcunmedyaproject1Entities1 db = new DbAcunmedyaproject1Entities1();

        //GET:Testimonial
        public ActionResult Index()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }  
        public ActionResult DeleteTestimonial(int id)
        {
            var values =db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

    }
}
