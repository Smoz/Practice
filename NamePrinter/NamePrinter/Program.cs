using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleRunning();
        }

        static void SampleRunning()
        {
            string name = RequestName();
            Console.WriteLine();
            NamePrinting(name);
            Console.ReadKey();
        }

        static string RequestName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static void NamePrinting(string name)
        {
            Console.WriteLine("Nice to meet you " + name + "!");
        }
    }
}
