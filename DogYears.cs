using System;

namespace DogYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your dogs age in human years > ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(dogYears(num1));
        }
        private static int dogYears(double humanYears)
        {
            int dogYearsOld = 0;
            if (humanYears <= 2)
            {
                dogYearsOld = Convert.ToInt32(humanYears * 12);
            }
            else
            {
                dogYearsOld = Convert.ToInt32(24 + (6 * (humanYears - 2)));
            }
            return dogYearsOld;
        }
    }
}