using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;
namespace WebApplication11.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        //MVC MODEL VİEW CONTROLLER
        DbAcunmedyaproject1Entities1 db = new DbAcunmedyaproject1Entities1();
       
        public ActionResult Index()
        {
            //string byte int liste
            var values = db.TblCategory.ToList();  //select*from tbl_category
            return View(values);
        }
        public ActionResult DeleteCategory (int id)
        {
            var values = db.TblCategory.Find(id);//5
            db.TblCategory.Remove(values);
            db.SaveChanges();//sql deki ctrl+s
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory category)
        {
            db.TblCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
         public ActionResult UpdateCategory(int id)
        {
            var values=db.TblCategory.Find(id); 
            return View(values);
        }
        [HttpPost]
        public ActionResult  UpdateCategory(TblCategory model)

        {
           var value= db.TblCategory.Find(model.CategoryID);
            value.CategoryName= model.CategoryName; 
            db.SaveChanges();   
            return RedirectToAction("Index");   
        }
    }

    internal class DbAcunmedyaproject1Entities
    {
    }
}