using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalizingJQuery.Models;
namespace FinalizingJQuery.Controllers
{
    public class TaskFiveController : Controller
    {
        // GET: TaskFive
        public ActionResult TaskFive()
        {
            return View();
        }


        public JsonResult getCountries()
        {
            dbReviewEntities data = new dbReviewEntities();

            var countries = data.countries.ToList();

            return Json(countries, JsonRequestBehavior.AllowGet);
        }

    }
}