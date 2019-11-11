using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTheWay.Controllers
{
    public class ApplyController : Controller
    {
        public ActionResult Index()
        {
            return View("GetInvolved");
        }

        public ActionResult GetInvolved()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}