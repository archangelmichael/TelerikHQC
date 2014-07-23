namespace FactoryMethod
{
    using System;

    public class Car : Vehicle
    {
        public Car()
        {
            this.Type = VehicleType.SportsCar;
        }

        public override void Drive()
        {
            Console.WriteLine("Brand new car sped up the test track!");
        }
    }
}
