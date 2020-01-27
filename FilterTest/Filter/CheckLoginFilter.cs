using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace FilterTest.Filter
{
    public class CheckLoginFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            string aName = filterContext.ActionDescriptor.ActionName;//获取Action的名称
            string cName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;//获取控件器的名称

            //string username= filterContext.HttpContext.Session["username"].ToString();//获取Session的值

            if (cName=="Login"&&(aName=="Index"||aName=="Login"))
            {
              
            }
            else
            {
                if (filterContext.HttpContext.Session["username"] ==null)
                {
                    filterContext.Result = new RedirectResult("/Login/Index");//页面重定向
                }
                else
                {
                
                }
            }
        }
    }
}