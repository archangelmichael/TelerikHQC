using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IfStatements
{
    class FirstStatement
    {
        public static void CookPotato()
        {
            // doesn't compile if not instanced
            Potato potato = new Potato();

            // ... 
            if (potato != null)
            {
                if (potato.HasBeenPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }
        }

        private static void Cook(Potato potato)
        {
            // ..
        }
    }
}
