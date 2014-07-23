namespace FactoryMethod
{
    using System;

    public class VehiclesMain
    {
        static void Main(string[] args)
        {
            var bmw = new Bmw();
            var man = new Man();
            var nissan = new Nissan();

            Vehicle sport = bmw.ManufactureVehicle();
            Vehicle jeep = man.ManufactureVehicle();
            Vehicle truck = nissan.ManufactureVehicle();
            
            PrintSpecs(sport);
            sport.Drive();
            Console.WriteLine();
            PrintSpecs(jeep);
            jeep.Drive();
            Console.WriteLine();
            PrintSpecs(truck);
            truck.Drive();

        }

        public static void PrintSpecs(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle type : {0}", vehicle.Type);
            Console.WriteLine("Vehicle model : {0}", vehicle.Model);
            Console.WriteLine("Vehicle power : {0}", vehicle.HorsePower);
            Console.WriteLine("Vehicle price : ${0}", vehicle.Price);

        }
    }
}
