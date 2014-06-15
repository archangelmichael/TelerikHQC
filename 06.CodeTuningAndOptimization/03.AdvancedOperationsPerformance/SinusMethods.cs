namespace _03.AdvancedOperationsPerformance
{
    using System;

    public class SinusMethods
    {
        internal static void CalcSinusFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step, Math.Sin(i)) { }
        }

        internal static void CalcSinusDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step, Math.Sin(i)) { }
        }

        internal static void CalcSinusDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step, Math.Sin((double)i)) { }
        }
    }
}
