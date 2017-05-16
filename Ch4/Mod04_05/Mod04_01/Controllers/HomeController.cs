using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod04_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Lab04_05
        public ActionResult GetVideo()
        {
            return File("~/Content/movie.mp4", "video/mp4");
        }
    }
}