using Mod02_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        // GET: Opera/Index?operaId=111&title=xx&year=1923&composer=John
        public ActionResult Index(Opera opera)
        {
            //var test = ModelState.IsValid;
            //Opera o = new Opera()
            //{
            //    OperaID = opera.OperaID,
            //    Title = opera.Title,
            //    Year = opera.Year,
            //    Composer = opera.Composer
            //};

            return View(opera);
        }
    }
}