using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SchoolContext schoolContext = new SchoolContext();
            Student zhangsan = new Student { FirstMidName = "zhang", LastName = "san", EnrollmentDate = DateTime.Now.Date };
            schoolContext.Students.Add(zhangsan);
            schoolContext.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}