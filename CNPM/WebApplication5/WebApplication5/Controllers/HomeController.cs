using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult OrderSPs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}