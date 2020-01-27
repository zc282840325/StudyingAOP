using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTest.Filter
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;//其他异常不执行了
            string path = AppDomain.CurrentDomain.BaseDirectory + "err.txt";
            Exception ex = filterContext.Exception;//获取异常信息
            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH;mm;ss").ToString() + ex.ToString() + "\r\n");
        }
    }
}