using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            ReverseNumbers(numbers);
            PrintNumbers(numbers);

            Console.ReadKey();
        }

        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
            {
                // The index starts at 0 but I want to start
                // with 1 so I'm adding 1 here.

                numbers[index] = index + 1;
            }

            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index] + " ");
            }
            Console.WriteLine();
        }

        static void ReverseNumbers(int[] numbers)
        {
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                firstIndex++;
                secondIndex--;
            }
        }
        
    }
}
