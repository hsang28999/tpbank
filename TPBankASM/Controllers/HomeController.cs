using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPBankASM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Details";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Title = "History";

            return View();
        }

        public ActionResult Deposit()
        {
            ViewBag.Title = "Deposit";

            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Title = "Menu";

            return View();
        }
    }
}
