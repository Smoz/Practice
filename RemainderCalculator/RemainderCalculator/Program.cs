using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numerator = 0;
            int denominator = 0;
            

            Console.Write("Enter a numerator: ");
            numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter a denominator: ");
            denominator = Convert.ToInt32(Console.ReadLine());

            int remainder = numerator % denominator;
            Console.Write("The remainder is: " + remainder);

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
