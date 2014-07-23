using System;
using System.Linq;

namespace Calculate
{
    public class SimpleMath
    {
        /// <summary>
        /// Calculates the sum of two floating-point numbers
        /// </summary>
        /// <param name="a">first floating point addend</param>
        /// <param name="b">second floating point addend</param>
        /// <returns>sum of two floating-point numbers</returns>
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        ///  Calculates the diffrence of two floating-point numbers
        /// </summary>
        /// <param name="a">first floating point subtractive</param>
        /// <param name="b">second floating point subtractive</param>
        /// <returns>diffrence of two floating-point numbers</returns>
        public static double Substract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        ///  Calculates the product of two floating-point numbers
        /// </summary>
        /// <param name="a">first floating point multiplier</param>
        /// <param name="b">second floating point multiplier</param>
        /// <returns>product of two floating-point numbers</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        ///  Calculates the result of division of two floating-point numbers
        /// </summary>
        /// <param name="a">dividend</param>
        /// <param name="b">divisor</param>
        /// <returns> division of two floating-point numbers</returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
