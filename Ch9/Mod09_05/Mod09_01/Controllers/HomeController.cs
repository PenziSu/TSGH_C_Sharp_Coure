using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod09_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: SelectorDemo
        public ActionResult SelectorDemo()
            
        {
            return View();
        }

        // GET: index2
        public ActionResult Index2()
        {
            return View();
        }

        //GET: Home/JsonData
        //GET: Home/JsonData/123?name=John
        public ActionResult JsonData(string id, string name)
        {
            //當Ajax呼叫時就回傳Json，如果用瀏覽器呼叫就回傳網頁
            if (Request.IsAjaxRequest())
            {
                var data = new
                {
                    empId = id,
                    EmpName = name,
                    Age = DateTime.Now.Millisecond
                };
                //以JSON格式回傳資料
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            return View();            
        }

        //GET: Home/AjaxDemo        
        public ActionResult AjaxDemo(string id, string name)
        {            
            return View();
        }
    }
}