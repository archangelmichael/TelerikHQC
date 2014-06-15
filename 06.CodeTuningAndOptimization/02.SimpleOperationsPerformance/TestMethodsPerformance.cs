/* Write a program to compare the performance of add, subtract, increment, multiply, divide 
 * for int, long, float, double and decimal values. */
namespace _02.SimpleOperationsPerformance
{
    using System;
    using System.Diagnostics;

    public class TestMethodsPerformance
    {
        public static void Main(string[] args)
        {
            AddMethods.AddInt(1, 500000); 
            AddMethods.AddLong(1L, 500000L); 
            AddMethods.AddFloat(1f, 500000f); 
            AddMethods.AddDouble(1d, 500000d); 
            AddMethods.AddDecimal(1m, 500000m); 

            SubstractMethods.SubstractInt(500000, 1);
            SubstractMethods.SubstractLong(500000L, 1L);
            SubstractMethods.SubstractFloat(500000f, 1f);
            SubstractMethods.SubstractDouble(500000d, 1d);
            SubstractMethods.SubstractDecimal(500000m, 1m);
            
            MultiplyMethods.MultiplyInt(1, 500000, 5);
            MultiplyMethods.MultiplyLong(1L, 500000L, 5L);
            MultiplyMethods.MultiplyFloat(1f, 500000f, 5f);
            MultiplyMethods.MultiplyDouble(1d, 500000d, 5d);
            MultiplyMethods.MultiplyDecimal(1m, 500000m, 5m);

            DivideMethods.DivideInt(500000, 1, 2);
            DivideMethods.DivideLong(500000L, 1L, 2L);
            DivideMethods.DivideFloat(500000f, 1f, 2f);
            DivideMethods.DivideDouble(500000d, 1d, 2d);
            DivideMethods.DivideDecimal(500000m, 1m, 2m);
        }
    }
}
