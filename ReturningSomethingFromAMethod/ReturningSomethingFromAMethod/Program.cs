using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningSomethingFromAMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerScore = CalculatePlayerScore();
            Console.WriteLine(playerScore);
            GetNumberFromUser();
            Console.ReadKey();
        }

        static int GetNumberFromUser()
        {
            int usersNumber = 0;

            while (usersNumber < 1 || usersNumber > 10)
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                string usersResponse = Console.ReadLine();
                usersNumber = Convert.ToInt32(usersResponse);
            }

            return usersNumber;
        }

        static int CalculatePlayerScore()
        {
            int livesLeft = 3;
            int underlingsDestroyed = 17;
            int minionsDestroyed = 4;
            int bossesDestroyed = 1;
            

            // If the player is out of lives, they lose all their points.
            if(livesLeft == 0)
            {
                return 0;
            }

            // Otherwise the player gets 10 points per underling destroyed, 100 points
            // per minion, and 1000 points per boss.
            return underlingsDestroyed * 10 + minionsDestroyed * 100 + bossesDestroyed * 1000;
        }
    }
}
