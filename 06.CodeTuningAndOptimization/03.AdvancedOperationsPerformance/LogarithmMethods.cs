namespace _03.AdvancedOperationsPerformance
{
    using System;

    public class LogarithmMethods
    {
        internal static void CalcLogarithmFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step, Math.Log(i)) { }
        }

        internal static void CalcLogarithmDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step, Math.Log(i)) { }
        }

        internal static void CalcLogarithmDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step, Math.Log((double)i)) { }
        }
    }
}
