using System;
using System.Threading.Tasks.Sources;

namespace DiceGame
{
    class Program
    {
        //initialise random class
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //user prompt to roll
            Console.Write("Press any key to roll 3 dice. ");
            Console.ReadKey();
            //generate three random numbers, >= 1, < 7
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            //output dice rolls
            Console.WriteLine("You have rolled a {0}, a {1} and a {2}", dice1, dice2, dice3);
            //calculate using subroutines and output
            int score = diceCalc(dice1, dice2, dice3);
            Console.WriteLine("You scored {0} points", score);
        }
        private static int diceCalc(int roll1, int roll2, int roll3)
        {
            //initialise score variable
            int score = 0;
            if (roll1 == roll2 && roll2 == roll3)
            {
                //if all three dice rolls equal each other, add together
                score = roll1 * 3;
            }
            //for the next three, add the two dice rolls that equal each other and minus the roll that is not equal
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
            //if the score is less than 0, make it 0
            if (score < 0) {score = 0;}
            return score;
        }
    }
}
