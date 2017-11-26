using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarsalesDataAccess;
using CarsalesApp.Factory;
using CarsalesApp.Managers;



namespace CarsalesApp.Controllers
{
    public class VehicleController : ApiController
    {
        CarsalesDBEntities entities = new CarsalesDBEntities();

        #region old_code
        /*
        public IEnumerable<vechile_type> GetVechileTypes()
        {
            return entities.vechile_type.ToList();
        }

        public IEnumerable<Car> Get()
        {
            return entities.Cars.ToList();
        }

        public Car Get(int id)
        {
            return entities.Cars.FirstOrDefault(e => e.Id == id);
        }
        
        public HttpResponseMessage Post([FromBody] Car car)
        {
            try
            {

                entities.Cars.Add(car);
                entities.SaveChanges();

                var message = Request.CreateResponse(HttpStatusCode.Created, car);
                message.Headers.Location = new Uri(Request.RequestUri + car.Id.ToString());
                return message;
            }
            catch (Exception ex)
            {
               return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }

        }


        public void Edit(int Id,int type)
        {
            VehicleManagerFactory vehFactory = new VehicleManagerFactory();
            IVehicleManager vehManager = vehFactory.GetVehicleManager(Id);
            vehManager.GetType();

        }

    */
        #endregion

        public IHttpActionResult GetAllVehicles()
        {
            List<vehicle> objVehicles = entities.vehicles.ToList();
            return Ok(objVehicles);
        }


    }
}
