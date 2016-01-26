using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTercerDia.Controllers
{
    //[Authorize(Users = @"jonas-pc\Juan")]
    public class HomeController : Controller
    {
        
        //[Authorize(Users= @"jonas-pc\Juan")]
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Users = @"jonas-pc\Juan")]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}