using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpForTheHomelessProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We Care About Your Needs! We Are Here To Help You!";

            return View();
        }

        //Rebuild all the time go back and refresh

        public ActionResult Contact()
        {
            ViewBag.Message = "Please Contact Our Office at any time!";

            return View();
        }

        
    }
}