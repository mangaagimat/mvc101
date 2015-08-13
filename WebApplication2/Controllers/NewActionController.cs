using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class NewActionController : Controller
    {
        // GET: NewAction
        public ActionResult Index()
        {
            return View("~/Views/Shared/View.cshtml");
        }
    }
}