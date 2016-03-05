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
        static SurveyResults results;

        public ActionResult Index ()
        {
            return View ();
        }

        public ActionResult Survey()
        {
            return View ();
        }

        public ActionResult ResultTable()
        {
            Console.WriteLine (results);
            if (results == null)
                results = new SurveyResults ();
            return View (results);
        }

        [HttpPost]
        public ActionResult ProcessForm(string opinion)
        {
            if (results == null)
                results = new SurveyResults ();
            results.Data.Add (opinion);
            return View ("FormProcessed");
        }
    }
}

