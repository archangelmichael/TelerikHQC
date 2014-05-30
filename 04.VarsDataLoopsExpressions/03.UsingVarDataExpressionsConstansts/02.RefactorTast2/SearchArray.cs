using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefactorTast2
{
    //Refactor the following code to apply variable usage and naming best practices.
    class SearchArray
    {
        public void PrintArrayInformation(double[] givenArray)
        {
            double minElement = this.FindMinInArray(givenArray);
            double maxElement = this.FindMaxInArray(givenArray);
            double averageOfElements = this.FindAverageOfElements(givenArray);
            this.PrintInformation(minElement, maxElement, averageOfElements);
        }

        private double FindMinInArray(double[] arr)
        {
            double minElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }
            return minElement;
        }

        private double FindMaxInArray(double[] arr)
        {
            double maxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            return maxElement;
        }

        private double FindAverageOfElements(double[] arr)
        {
            double sumOfElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumOfElements += arr[i];
            }

            return sumOfElements / arr.Length;
        }

        private void PrintInformation(double minElement, double maxElement, double averageOfElements)
        {
            Console.WriteLine("Max element: {0}; Min element: {1}; Average: {2}", maxElement, minElement, averageOfElements);
        }
    }
}
