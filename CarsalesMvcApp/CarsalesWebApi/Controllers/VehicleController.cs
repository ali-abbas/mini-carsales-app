using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CarsalesDataAccess;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarsalesWebApi.Controllers
{

    [System.Web.Http.RoutePrefix("api/vehicles")]
    public class VehicleController : ApiController
    {
        private CarsalesDataAccess.CarsalesDBEntities objDe = new CarsalesDBEntities();

        [System.Web.Http.HttpGet]
        public HttpResponseMessage findAll()
        {
            var serializeData = JsonConvert.SerializeObject(objDe.vehicles.ToList());
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StringContent(serializeData);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return response;
        }
       
    }
}