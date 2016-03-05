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
        static SurveyData results;

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
                results = new SurveyData ();
            return View (results);
        }

        [HttpPost]
        public ActionResult ProcessForm(string opinion)
        {
            if (results == null)
                results = new SurveyData ();
            results.Data.Add (new SurveyResult(opinion));
            return View ("FormProcessed");
        }
    }
}

