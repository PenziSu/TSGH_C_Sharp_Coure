using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mod02_01
{
    public class LogActionFilter:ActionFilterAttribute
    {
        private void Log(string methodName, RouteData routeDate)
        {
            var controllerName = routeDate.Values["controller"];
            var actionName = routeDate.Values["action"];
            var message = string.Format("{0} controller:{1}, action:{2}", methodName, controllerName, actionName);
            Debug.WriteLine(message);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Debug.WriteLine("This Event Fired: OnActionExecuting.(method執行前)");
            Log("OnActionExecuting",filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Debug.WriteLine("This Event Fired: OnActionExecuted.(method執行後)");
            Log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //Debug.WriteLine("This Event Fired: OnResultExecuting.(Result執行前)");
            Log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Debug.WriteLine("This Event Fired: OnResultExecuted.(Result執行前)");
            Log("OnResultExecuted", filterContext.RouteData);
        }
        
    }    
}