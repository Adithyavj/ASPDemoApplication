using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // Default for a controller is index..
        // GET: People
        public ActionResult Index()
        {
            return View();
        }


    }
}