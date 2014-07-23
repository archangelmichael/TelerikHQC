namespace FactoryMethod
{
    using System;

    public class Jeep : Vehicle
    {
        public Jeep()
        {
            this.Type = VehicleType.Jeep;
        }

        public override void Drive()
        {
            Console.WriteLine("A jeep just went off the road into the forest!");
        }
    }
}
