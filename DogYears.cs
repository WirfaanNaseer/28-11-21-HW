using System;

namespace DogYears
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.Write("Input your dogs age in human years > ");
            //use double in order to allow for decimal points
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(dogYears(num1));
        }
        private static int dogYears(double humanYears)
        {
            //initialise variable
            int dogYearsOld = 0;
            //check if older than 2
            if (humanYears <= 2)
            {
                //times 12 if equal or less than 2
                dogYearsOld = Convert.ToInt32(humanYears * 12);
            }
            else
            {
                //24 plus 6 for every year after
                dogYearsOld = Convert.ToInt32(24 + (6 * (humanYears - 2)));
            }
            return dogYearsOld;
        }
    }
}
