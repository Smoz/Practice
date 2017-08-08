using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAndAveragingRevisited
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set up the array.
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            // Determine the minimum.
            int currentMinimum = Int32.MaxValue;
            foreach (int number in array)
            {
                if (number < currentMinimum) { currentMinimum = number; }
            }
            Console.WriteLine("Minimum: " + currentMinimum);

            // Determine the average value of the array.
            int total = 0;
            foreach (int number in array)
            {
                total += number;
            }
            float average = (float)total / array.Length;
            Console.WriteLine("Average: " + average);

            Console.ReadKey();

        }
    }
}
