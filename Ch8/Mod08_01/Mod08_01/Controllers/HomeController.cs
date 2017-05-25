using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod08_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET: Home/HelloWorld
        public ActionResult HelloWorld()
        {
            ViewBag.message = "HelloWorld: " + DateTime.Now.ToString();
            return PartialView();

        }
    }
}