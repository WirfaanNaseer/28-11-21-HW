using System;
using System.Threading.Tasks.Sources;

namespace DiceGame
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Write("Press any key to roll 3 dice. ");
            Console.ReadKey();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            Console.WriteLine("You have rolled a {0}, a {1} and a {2}", dice1, dice2, dice3);
            int score = diceCalc(dice1, dice2, dice3);
            Console.WriteLine("You scored {0} points", score);
        }
        private static int diceCalc(int roll1, int roll2, int roll3)
        {
            int score = 0;
            if (roll1 == roll2 && roll2 == roll3)
            {
                score = roll1 * 3;
            }
            else if (roll1 == roll2)
            {
                score = roll1 * 2 - roll3;
            }
            else if (roll2 == roll3)
            {
                score = roll2 * 2 - roll1;
            }
            else if (roll1 == roll3)
            {
                score = roll1 * 2 - roll2;
            }
            if (score < 0) {score = 0;}
            return score;
        }
    }
}