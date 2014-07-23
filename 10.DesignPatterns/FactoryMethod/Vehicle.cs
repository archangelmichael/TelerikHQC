namespace FactoryMethod
{
    using System;

    public enum VehicleType { Jeep, Truck, SportsCar};

    public abstract class Vehicle : IDrivable
    {
        public VehicleType Type { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public int Price { get; set; }

        public abstract void Drive();
    }
}
