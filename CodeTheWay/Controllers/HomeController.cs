using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTheWay.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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
        public ActionResult GetInvolved()
        {
            ViewBag.Message = "Find out how to get involved with our organization.";

            return View();
        }

        public ActionResult Donor()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
    }
}