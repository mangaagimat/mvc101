using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PlacesController : Controller
    {
        // NOTE: action name should match to viewname
        public ActionResult ViewPlace(Department dept)
        {
            return View();
        }
    }
}