using System;
using System.Linq;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {    
        static void PrintDigitFrequency()
        {
            List<int> list;

            string number = Console.ReadLine();

            list = number.Select(c => int.Parse(c.ToString())).ToList();

            var result = list.GroupBy(item => item).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i].Key} appears {result[i].Count()} times");
            }
        }

        static void Main()
        {
            PrintDigitFrequency();
        }
    }
}