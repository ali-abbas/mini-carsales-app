using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsalesDataAccess;

namespace CarsalesMvcApp.Controllers
{
    public class VehicleController : Controller
    {
        CarsalesDBEntities entities = new CarsalesDBEntities();
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetVehicles()
        {
            var result = entities.vehicles.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}