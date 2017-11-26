using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarsalesApp.Managers;
using CarsalesApp.Controllers;
using CarsalesDataAccess;

namespace CarsalesApp.Factory
{
    public class VehicleManagerFactory
    {
        VehicleController objVehicalController = new VehicleController();
        CarsalesDBEntities entities = new CarsalesDBEntities();

        public IVehicleManager GetVehicleManager(int vehicleType)
        {
          //   IEnumerable<vechile_type> objVehicleTypes  = objVehicalController.GetVechileTypes();
            IVehicleManager returnValue = null;
            returnValue = new VehicleCarsManager();
            if (vehicleType == 1)
            {
                returnValue = new VehicleCarsManager();
            }

            if(vehicleType == 2)
            {
                returnValue = new VehicleBikesManager();
            }

            return returnValue;
         
        }

    }
}