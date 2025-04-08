using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;
namespace WebApplication11.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DbAcunmedyaproject1Entities1 db = new DbAcunmedyaproject1Entities1();
        public ActionResult Index()
        {
            var values = db.TblEducation.ToList();
            return View(values);
        }
    }
}