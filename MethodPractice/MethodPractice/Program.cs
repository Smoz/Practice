using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BeforeCounting();
            CountToTen();
            AfterCounting();
            Console.ReadKey();
        }

        static void CountToTen()
        {
            for(int index = 1; index <= 10; index++)
            {
                Console.WriteLine(index);
            }
            
        }

        static void BeforeCounting()
        {
            Console.WriteLine("Hello! I'm greeting you from the 'Greeting Method' before I start counting!");
        }
        static void AfterCounting()
        {
            Console.WriteLine("I'm done counting and am inside the 'AfterCounting' Method! Goodbye!");
        }
    }
}
