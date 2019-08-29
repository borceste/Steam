using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Steam.DataAccessLayer;
using Steam.Models;

namespace Steam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            
            
            DataClass dataClass = new DataClass();
            List<Game> games = dataClass.Games.ToList();

            return View(games);
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
    }
}