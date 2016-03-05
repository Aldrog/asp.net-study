using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class SurveyController : Controller
    {
        private List<string> results;

        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult ProcessForm(string opinion)
        {
            results.Add (opinion);
            return View ("FormProcessed");
        }
    }
}
