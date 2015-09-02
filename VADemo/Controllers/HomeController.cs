using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VADemo.Models;

namespace VADemo.Controllers
{
    public class HomeController : Controller
    {
        private VA_DBContext db = new VA_DBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "IS Systems Development Services Senior ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Info";

            return View();
        }
    }
}