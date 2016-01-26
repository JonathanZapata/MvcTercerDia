using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTercerDia.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Request.Form["txtUserName"] == "Jonas" && Request.Form["txtPassword"] == "1234")
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie("Jonas", true);
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}