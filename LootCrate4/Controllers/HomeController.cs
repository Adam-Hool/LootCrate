using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LootCrate4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Toys()
        {
            return View();
        }
        public ActionResult Shirts()
        {
            return View();
        }
        public ActionResult VideoGames()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutLootCrate()
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