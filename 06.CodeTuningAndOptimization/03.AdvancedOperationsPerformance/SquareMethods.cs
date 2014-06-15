﻿namespace _03.AdvancedOperationsPerformance
{
    using System;

    public class SquareMethods
    {
        public static void CalcSqrtFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step, Math.Sqrt(i)) { }
        }

        public static void CalcSqrtDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step, Math.Sqrt(i)) { }
        }

        public static void CalcSqrtDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step, Math.Sqrt((double)i)) { }
        }
    }
}
