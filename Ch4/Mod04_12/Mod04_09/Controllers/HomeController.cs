using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod04_09.DAL;
using Mod04_09.Models;

namespace Mod04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ProductByID(int id)
        {
            //呼叫商業邏輯層的物件呈現資料
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductByID(id);

            return View(result);
        } 
        
        public ActionResult ProductByCategoryID(int id)
        {
            ProductSystem sys = new ProductSystem();
            var result = sys.GetproductsByCategoryID(id);

            return View(result);
        }       
    }
}