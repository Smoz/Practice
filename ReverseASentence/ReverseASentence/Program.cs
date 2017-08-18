using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSentence();
            Console.ReadKey();

        }

        public static void GetSentence()
        {
            string str;
            Console.Write("Please type a sentence of at least 3 words: ");
            str = Console.ReadLine();
            string reverse = ReverseSentence(str);
            Console.WriteLine(reverse);
        }

        public static string ReverseSentence(string sentence)
        {
            
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
