using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBEmpire.Backend;
using DBEmpire.Models.Login;

namespace DBEmpire.Controllers
{
    public class LoginController : Controller
    {

        public static string Name = "Login";
        public static string ActionIndex = "Index";

        [HttpGet]
        public ActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            var result = UserService.GetUser(model.UserName);

            return RedirectToAction(HomeController.ActionIndex, HomeController.Name, new {name = result.UserName});
        }

    }
}