using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myrepository1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome this is my application in appharbor  arwa agha!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
