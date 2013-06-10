using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3_Scaffolding.Models;

namespace Mvc3_Scaffolding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult Search(String q)
        {
            MusicStoreDB storeDB = new MusicStoreDB();
            var albums = storeDB.Albums
                                .Include("Artist")
                                .Where(a => a.Title.Contains(q) || q == null)
                                .Take(10);
            return View(albums);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
