using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapiprojetc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //manish gupt
            //int 
            //comment by ck
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
