using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Controllers
{
    /// <summary>
    /// Home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index this instance.
        /// </summary>
        public ActionResult Index()
        {
            ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";
            return View();
        }
    }
}

