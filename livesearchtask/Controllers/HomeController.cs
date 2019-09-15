using livesearchtask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace livesearchtask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDataEntities db = new EmployeeDataEntities();
            return View(db.employees.ToList());
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