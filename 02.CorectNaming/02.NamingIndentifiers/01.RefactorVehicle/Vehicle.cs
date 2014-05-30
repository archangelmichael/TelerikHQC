using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVehicle
{
    public class Vehicle
    {
        const int MAX_COUNT = 6; // CAN BE DELETED CAUSE IT IS NOT USED ANYWHERE

        public class Car
        {
            public void MakeExplosion(bool hasGasoline)
            {
                string explosion = hasGasoline.ToString();
                Console.WriteLine(explosion);
            }
        }
        public static void Main()
        {
            Vehicle.Car carUsedInActionMovie = new Vehicle.Car();
            carUsedInActionMovie.MakeExplosion(true);
        }
    }
}
