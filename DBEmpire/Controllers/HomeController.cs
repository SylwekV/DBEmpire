using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBEmpire.Backend;
using DBEmpire.Models.Home;

namespace DBEmpire.Controllers
{
    public class HomeController : Controller
    {
        public static string Name = "Home";
        public static string ActionIndex = "Index";

        [HttpGet]
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();

            if (HttpContext.Session != null && (bool?)HttpContext.Session["UserLoggedIn"] == true)
            {
                model.UserName = HttpContext.Session["UserName"].ToString();
            }
            else
            {
                return RedirectToAction(LoginController.ActionIndex, LoginController.Name);
            }

            return View(model);
        }
    }
}