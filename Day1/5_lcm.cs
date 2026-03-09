using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void FindLCM()
        {
            List<int> items = new List<int>();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Math.Min(num1, num2); i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    items.Add(i);
                }
            }

            int numerator = num1 * num2;
            int denominator = items[items.Count - 1];

            int lcm = numerator / denominator;

            Console.Write(lcm);
        }

        static void Main()
        {
            FindLCM();
        }
    }
}