using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod03_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/RedirDemo
        public ActionResult RedirDemo()
        {
            return RedirectToAction("Index","Home");
        }
    }
}