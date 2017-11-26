using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsalesDataAccess;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarsalesMvcApp.Controllers
{
    public class VehicleController : Controller
    {
        CarsalesDBEntities entities = new CarsalesDBEntities();
        // GET: Vehicle

        string BaseUrl = "http://localhost:56052";
        public async Task<ActionResult> Index()
        {
            List<vehicle> objVeh = new List<vehicle>();

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                client.DefaultRequestHeaders.Clear();

                //define request data format
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Sending request to find web api Rest service resouces findAll
                HttpResponseMessage Res = await client.GetAsync("api/vehicle");

                //Checking the response is successfull or not which is sent using httpClinet

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the respoinse details recieved from web api
                    var VehicleResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response from web api and storing into Vehicle list

                    objVeh = JsonConvert.DeserializeObject<List<vehicle>>(VehicleResponse);


                }

            }

            return View(objVeh);
        }
          
        public JsonResult GetVehicles()
        {
            var result = entities.vehicles.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}