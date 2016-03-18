using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBEmpire.Backend;
using DBEmpire.Business.Classes.Login;
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
            var loginResult = UserProvider.LogIn(model.UserName, model.Password);

            if (loginResult.Response == LoginResponse.Success)
            {
                if (HttpContext.Session != null)
                {
                    HttpContext.Session["UserName"] = loginResult.User.UserName;
                    HttpContext.Session["UserID"] = loginResult.User.UserID;

                    HttpContext.Session["UserLoggedIn"] = true;
                }

                return RedirectToAction(HomeController.ActionIndex, HomeController.Name);
            }
            else
            {
                return View();
            }

            
        }

    }
}