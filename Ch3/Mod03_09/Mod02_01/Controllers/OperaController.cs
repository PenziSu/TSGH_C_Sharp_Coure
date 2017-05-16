using Mod02_01.DAL;
using Mod02_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        // GET: Opera/Index?operaId=111&title=xx&year=1923&composer=John
        //public ActionResult Index(Opera opera)
        //{
        //    //var test = ModelState.IsValid;
        //    //Opera o = new Opera()
        //    //{
        //    //    OperaID = opera.OperaID,
        //    //    Title = opera.Title,
        //    //    Year = opera.Year,
        //    //    Composer = opera.Composer
        //    //};

        //    return View(opera);
        //}

        // Lab2_4
        // GET: Opera/Index
        public ActionResult Index()
        {
            OperaContext context = new OperaContext();

            return View(context.Operas.ToList());
        }

        //Lab3_3
        //GET : Opera/Details/1
        //GET : Opera/Details?id=1
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperaContext context = new OperaContext();
            Opera o = context.Operas.Find(id);
            if(o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }

        //Lab3_4
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create( Opera opera)
        {
            if (ModelState.IsValid)
            {
                OperaContext context = new OperaContext();
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        //Lab3_7
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperaContext context = new OperaContext();
            Opera o = context.Operas.Find(id);
            if(o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }

        [HttpPost]
        public ActionResult Edit( Opera opera)
        {
            if (ModelState.IsValid)
            {
                OperaContext context = new OperaContext();
                context.Entry(opera).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        //Lab3_8
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    OperaContext context = new OperaContext();
        //    Opera o = context.Operas.Find(id);
        //    if (o == null)
        //        return HttpNotFound();
        //    return View(o);
        //}

        ////POST:
        ////POST:
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int? id)
        //{
        //    OperaContext context = new OperaContext();
        //    Opera o = context.Operas.Find(id);
        //    context.Operas.Remove(o);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            OperaContext context = new OperaContext();
            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            context.Operas.Remove(o);
            context.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}