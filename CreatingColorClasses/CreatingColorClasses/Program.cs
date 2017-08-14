using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingColorClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Ball bigRed = new Ball(new Color(255, 0, 0), 5);
            Ball littleBlue = new Ball(new Color(0, 0, 255), 3);

            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();

            Console.WriteLine(bigRed.GetTimesThrown());

            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            littleBlue.Throw();
            littleBlue.Throw();
            Console.WriteLine(littleBlue.GetTimesThrown());

            littleBlue.Pop();
            littleBlue.Throw();
            Console.WriteLine(littleBlue.GetTimesThrown());

            Console.ReadKey();

        }
    }
}
