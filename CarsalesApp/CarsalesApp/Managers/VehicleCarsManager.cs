using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsalesApp.Managers
{
    public class VehicleCarsManager : IVehicleManager
    {
        string[] BikeTypes = new string[] { "hatchback", "sedan" };

        public string[] GetVehicleType()
        {
            return BikeTypes;
        }
    }
}