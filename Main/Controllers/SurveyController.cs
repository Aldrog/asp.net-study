using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class SurveyController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult ProcessForm(string opinion)
        {
            ViewBag.SurveyResult = opinion; //Request.Params ["opinion"];
            return View ("FormProcessed");
        }
    }
}
