namespace FactoryMethod
{
    using System;

    public class Man : VehicleManufacturer
    {
        public override Vehicle ManufactureVehicle()
        {
            var truck = new Truck
            {
                Model = "TGX 26.480 6x4 BBS",
                HorsePower = 540,
                Price = 40320
            };

            return truck;
        }
    }
}
