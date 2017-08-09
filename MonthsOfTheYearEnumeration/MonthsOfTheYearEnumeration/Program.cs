using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfTheYearEnumeration
{

    // Months of the year
    public enum MonthsOfTheYear
    {
        January = 1, February = 2, March = 3,
        April = 4, May = 5, June = 6,
        July = 7, August = 8, September = 9,
        October = 10, November = 11, December = 12
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Get the month number from the user.
            Console.WriteLine("Enter a number from 1 to 12: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            // Check the range to make sure it is valid.
            if (monthNumber > 0 && monthNumber <= 12)
            {
                // Print out the corresponding month name.
                MonthsOfTheYear month = (MonthsOfTheYear)monthNumber;
                Console.WriteLine(month);
            }
            else // If it's not in the right range, print an error message.
            {
                Console.WriteLine("That number was too high or too low.");
            }

            Console.ReadKey();
        }
    }
}
