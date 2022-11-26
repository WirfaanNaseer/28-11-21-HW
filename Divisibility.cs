using System;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number > ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input another number > ");
            int num2 = Convert.ToInt32(Console.ReadLine());
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
            if (num2 == 0)
            {
                return false;
            }
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