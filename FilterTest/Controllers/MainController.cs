using FilterTest.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterTest.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        [Log2ActionFilter]
        public ActionResult Index()
        {
            return Content("我是Index");
        }
        public ActionResult zz()
        {
            return Content("开始转账！");
        }
    }
}