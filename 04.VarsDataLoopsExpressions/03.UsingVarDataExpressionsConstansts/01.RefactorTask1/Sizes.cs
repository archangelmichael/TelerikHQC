using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorTask1
{
    // Refactor the following code to use proper variable naming and simplified expressions
    class Sizes
    {
        public class Size
        {
            private double width, height;

            public Size(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }

            public double Width
            {
                get
                {
                    return this.width;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Size cannot be negative!");
                    }
                    this.width = value;
                }
            }

            public double Height
            {
                get
                {
                    return this.height;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Size cannot be negative!");
                    }
                    this.height = value;
                }
            }
        }

        public static Size GetRotatedSize(Size size, double figureRotationAngle)
        {
            double angleCos = Math.Abs(Math.Cos(figureRotationAngle));
            double angleSin = Math.Abs(Math.Sin(figureRotationAngle));
            return new Size(angleCos * size.Width + angleSin * size.Height, 
                angleSin * size.Width + angleCos * size.Height);
        }
    
        static void Main(string[] args)
        {
            Size newSize = new Size(2.4, 4.5);
            Console.WriteLine("width: {0:F5}; height: {1:F5}", newSize.Width, newSize.Height);
            newSize = GetRotatedSize(newSize, 130);
            Console.WriteLine("width: {0:F5}; height: {1:F5}", newSize.Width, newSize.Height);
        }
    }
}
