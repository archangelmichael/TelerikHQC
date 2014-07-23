namespace FactoryMethod
{
    using System;

    public class Truck : Vehicle
    {
        public Truck()
        {
            this.Type = VehicleType.Truck;
        }

        public override void Drive()
        {
            Console.WriteLine("A huge truck entered the highway!");
        }
    }
}
