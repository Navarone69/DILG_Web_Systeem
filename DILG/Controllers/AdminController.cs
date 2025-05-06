using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DILG.Controllers
{
    public class AdminController : Controller
    {
        private DILG_DBEntities db = new DILG_DBEntities();
        // GET: Admin
        public ActionResult AdminLayout()
        {
            return View(); // This should return the view associated with AdminLayout
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult UserManager()
        {
            return View(db.Employees.ToList());
        }





        public ActionResult PositionManager()
        {
            return View();
        }
        public ActionResult OfficeManager()
        {
            return View();
        }

        public ActionResult ReportHistory() 
        {
            return View();
        }

       
    }
}