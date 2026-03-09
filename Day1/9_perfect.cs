using System;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void CheckPerfectNumber()
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfFactors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sumOfFactors = sumOfFactors + i;
            }

            if (number == sumOfFactors)
                Console.Write("Perfect number");
            else
                Console.Write("Not a Perfect number");
        }

        static void Main()
        {
            CheckPerfectNumber();
        }
    }
}