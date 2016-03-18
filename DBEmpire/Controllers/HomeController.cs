using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBEmpire.Controllers
{
    public class HomeController : Controller
    {
        public static string Name = "Home";
        public static string ActionIndex = "Index";

        [HttpGet]
        public ActionResult Index(string name = "")
        {
            return View(name);
        }
    }
}