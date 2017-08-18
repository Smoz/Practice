using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnResultOfExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 7;
            int c = 3;
            int d = 14;

            int result = a + b + c - d;

            Console.Write(result);
            Console.ReadKey();

        }
    }
}
