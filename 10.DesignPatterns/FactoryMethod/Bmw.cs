namespace FactoryMethod
{
    using System;

    public class Bmw : VehicleManufacturer
    {
        public override Vehicle ManufactureVehicle()
        {
            var sportsCar = new Car
            {
                Model = "M6",
                HorsePower = 560,
                Price = 118200
            };

            return sportsCar;
        }
    }
}
