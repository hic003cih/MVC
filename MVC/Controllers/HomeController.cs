using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.name = "ssss";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.hello = "hello222";

            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            var receiveName = name;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Message = "Your";

            return View();
        }
        public ActionResult Delete()
        {
            ViewBag.Message = "Your";

            return View();
        }
    }
}