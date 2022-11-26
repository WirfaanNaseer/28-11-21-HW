using System;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user inputs
            Console.Write("Input a number > ");
            //Convert the number to integers
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input another number > ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //Put the two numbers into the subroutine and if they are divisible
            if (isDivisible(num1, num2))
            {
                Console.WriteLine("The two numbers are divisible");
            }
            else
            {
                Console.WriteLine("The two numbers are not divisible");
            }
        }
        private static bool isDivisible(int num1, int num2)
        {
            //if the second number is 0 return false
            if (num2 == 0)
            {
                return false;
            }
            //using modulus check if there is a remainder when the two are divided
            if (num2 % num1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
