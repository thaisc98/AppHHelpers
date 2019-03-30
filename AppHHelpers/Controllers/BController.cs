using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppHHelpers.Controllers
{
    public class BController : Controller
    {
        // GET: B
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Go()
        {   
            return RedirectToAction("Index", "Helper");
        }
    }
}