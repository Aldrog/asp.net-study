using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        private List<string> results;

        public ActionResult Index ()
        {
            var mvcName = typeof(Controller).Assembly.GetName ();
            var isMono = Type.GetType ("Mono.Runtime") != null;

            ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

            return View ();
        }

        public ActionResult Survey()
        {
            return View ();
        }

        public ActionResult ResultTable()
        {
            if (results == null)
                results = new List<string> ();
            results.Add ("test");
            ViewData ["resultList"] = results;
            return View ();
        }

        [HttpPost]
        public ActionResult ProcessForm(string opinion)
        {
            if (results == null)
                results = new List<string> ();
            results.Add (opinion);
            return View ("FormProcessed");
        }
    }
}

