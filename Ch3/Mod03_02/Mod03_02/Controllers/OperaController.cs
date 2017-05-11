using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod03_02.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        public ActionResult Index()
        {
            ViewBag.OperaID = "1";
            ViewBag.Title = "FFFFF";
            ViewBag.Year = 1983;
            ViewBag.Composer = "Mark";
            return View();
        }
    }
}