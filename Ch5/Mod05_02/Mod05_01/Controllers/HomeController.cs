using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod05_01.Controllers
{
    //[HandleError(View = "aa")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/ExceptionDemo        
        public ActionResult ExceptionDemo()
        {
            int j = 0;
            int k = 10 / j;
            return View();
        }
    }
}