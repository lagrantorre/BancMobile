using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancMobile.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Banc Mobil";

            return View();
        }   

        public ActionResult About()
        {
            return View();
        }
    }
}
