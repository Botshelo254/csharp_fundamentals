using System;

namespace Day1
{
    class Program
    {
        static void NumberToWords()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                Console.Write("Zero");
            else if (number == 1)
                Console.Write("One");
            else if (number == 2)
                Console.Write("Two");
            else if (number == 3)
                Console.Write("Three");
            else if (number == 4)
                Console.Write("Four");
            else if (number == 5)
                Console.Write("Five");
            else if (number == 6)
                Console.Write("Six");
            else if (number == 7)
                Console.Write("Seven");
            else if (number == 8)
                Console.Write("Eight");
            else if (number == 9)
                Console.Write("Nine");
            else
                Console.Write("Only numbers between 0 & 9 allowed!!!");
        }

        static void Main()
        {
            NumberToWords();
        }
    }
}