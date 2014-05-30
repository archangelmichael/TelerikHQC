using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorClass
{
    class Kitchen
    {
        static void Main(string[] args)
        {
            Chef newChefInRestaurant = new Chef("Ronaldo");
            newChefInRestaurant.Cook();
        }
    }
}
