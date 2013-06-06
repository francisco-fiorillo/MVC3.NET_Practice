using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_TestApplication.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public String Index()
        {
            //return View();
            return "Welcome to the jungle! From Store.Index()";
        }

        // GET: /Store/Browse
        public String Browse(String id)
        {
            //return View();
            if (String.IsNullOrEmpty(id))
                return "Browsing all genres (no genre specified)";
            return HttpUtility.HtmlEncode("Browsing music library... Genre: " + id);
        }

        // GET: /Store/Details
        public String Details(String strDetail)
        {
            //return View();
            return HttpUtility.HtmlEncode("Welcome to the details! From Store.Details(). This detail was added: " + strDetail);
        }

    }
}
