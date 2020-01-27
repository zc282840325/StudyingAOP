using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTest.Filter
{
    public class Log2ActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string actioName = filterContext.ActionDescriptor.ActionName;
            string crrlName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string path = AppDomain.CurrentDomain.BaseDirectory + "log2.txt";
            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH;mm;ss").ToString() + "执行了" + crrlName + "." + actioName + "\r\n");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actioName = filterContext.ActionDescriptor.ActionName;
            string crrlName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            string path = AppDomain.CurrentDomain.BaseDirectory + "log2.txt";

            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH;mm;ss").ToString() + "将要执行" + crrlName + "." + actioName + "\r\n");
        }
    }
}