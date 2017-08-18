using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("First without the reverse method.");
            Console.WriteLine();
            ReverseWithout();

            Console.WriteLine();

            Console.WriteLine("Now with the reverse method.");
            Console.WriteLine();
            ReverseWith();

            Console.WriteLine();

            Console.WriteLine("Now with the linq reverse method.");
            Console.WriteLine();
            ReverseWithLinq();

            Console.ReadKey();            

        }

        // This method doesn't use the reverse method

        static void ReverseWithout()
        {
            string str, reverseString = "";
            int Length;
            Console.Write("Enter a string please:");
            Console.WriteLine();
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverseString = reverseString + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse string is: {0}", reverseString);
            
        }

        // This method uses the standard revers method

        static void ReverseWith()
        {
            string str;
            Console.Write("Enter a string please:");
            Console.WriteLine();
            str = Console.ReadLine();

            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            string strOutput = new string(strArray);
            Console.WriteLine("Reverse string is: {0}", strOutput);
        }

        // This method uses the linq reverse method

        static void ReverseWithLinq()
        {
            string str;
            Console.Write("Enter a string please:");
            Console.WriteLine();
            str = Console.ReadLine();

            string strOutput = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Reverse string is: {0}", strOutput);
        }
    }
}
