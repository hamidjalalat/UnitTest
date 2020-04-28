using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
     
            return View();
        }

        public ActionResult Test2()
        {
            ViewBag.Message = "HamidJalalat";
            return View();
        }
        public ActionResult Test3( Models.User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Ok";
            }
            ViewBag.Message = "Error";
            return View();
        }
    }
}