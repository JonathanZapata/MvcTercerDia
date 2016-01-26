using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTercerDia.Models;

namespace MvcTercerDia.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("FillCustomer");
        }

        public ActionResult FillCustomer()
        {
            return View();
        }

        public ActionResult CreateCustomer(Customer obj1)
        {
            return View("MostrarCustomer", obj1);
        }

        public ActionResult PostCustomer(Customer objcustomer)
        {
            if (ModelState.IsValid)
            {
                return View("~/Views/Customer/MostrarCustomer.cshtml", objcustomer);
            }
            else
                return View("~/Views/Home/Home.cshtml");

        }
    }
}