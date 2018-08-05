using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCChatTests.Hubs;
namespace MVCChatTests.Controllers
{
    public class HomeController : Controller
    {
        public static List<int> staticList = new List<int>();
        public ActionResult Index()
        {
            staticList.Add(1);
            ViewBag.Count = staticList.Count;
            Session["user"] = "User" + staticList.Count;
            ViewBag.Check = true;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page." + Session["user"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}