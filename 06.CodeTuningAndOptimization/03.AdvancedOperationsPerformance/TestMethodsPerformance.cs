/* Write a program to compare the performance of square root, natural logarithm, sinus 
 * for float, double and decimal values. */
namespace _03.AdvancedOperationsPerformance
{
    using System;

    internal class TestMethodsPerformance
    {
        private static void Main(string[] args)
        {
            SquareMethods.CalcSqrtFloat(1f, 10000f, 0.01f);
            SquareMethods.CalcSqrtDouble(1d, 10000d, 0.01d);
            SquareMethods.CalcSqrtDecimal(1m, 10000m, 0.01m);

            LogarithmMethods.CalcLogarithmFloat(1f, 10000f, 0.01f);
            LogarithmMethods.CalcLogarithmDouble(1d, 10000d, 0.01d);
            LogarithmMethods.CalcLogarithmDecimal(1m, 10000m, 0.01m);

            SinusMethods.CalcSinusFloat(1f, 10000f, 0.01f);
            SinusMethods.CalcSinusDouble(1d, 10000d, 0.01d);
            SinusMethods.CalcSinusDecimal(1m, 10000m, 0.01m);
        }
    }
}
