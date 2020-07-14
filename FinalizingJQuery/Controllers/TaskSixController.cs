using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalizingJQuery.Models;
namespace FinalizingJQuery.Controllers
{
    public class TaskSixController : Controller
    {
        // GET: TaskSix
        public ActionResult TaskSix()
        {
            return View();
        }

        public JsonResult getCountry()
        {
            dbReviewEntities data = new dbReviewEntities();

            var country = data.countries.ToList();

            return Json(country, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getCity()
        {
            dbReviewEntities data = new dbReviewEntities();
            country countryId = new country();
            var cId = countryId.id;
            var Clist = data.cities.Where(E => E.id == cId ).ToList();
            
            return Json(Clist, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getDistrict()
        {
            dbReviewEntities data = new dbReviewEntities();

            var country = data.countries.ToList();

            return Json(country, JsonRequestBehavior.AllowGet);
        }
    }
}