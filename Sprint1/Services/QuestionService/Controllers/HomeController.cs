using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application allows you to ask SitecoreGuild Questions.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Chris Williams - chris.williams@readwatchcreate.com";

            return View();
        }
    }
}