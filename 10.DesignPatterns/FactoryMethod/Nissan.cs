using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Nissan : VehicleManufacturer
    {
        public override Vehicle ManufactureVehicle()
        {
            var jeep = new Jeep
            {
                Model = "PATHFINDER",
                HorsePower = 260,
                Price = 29110
            };

            return jeep;
        }
    }
}
