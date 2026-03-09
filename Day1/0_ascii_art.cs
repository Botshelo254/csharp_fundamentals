using System;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void PrintAsciiArt()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        static void Main()
        {
            PrintAsciiArt();
        }
    }
}