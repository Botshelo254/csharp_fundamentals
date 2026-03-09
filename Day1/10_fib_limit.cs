using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void PrintFibonacciUpTo()
        {
            List<int> list = new List<int> {0, 1};

            int limit = int.Parse(Console.ReadLine());

            if (limit == 0)
                return;

            int next;

            int i = 2;
            while (list[list.Count - 1] + list[list.Count - 2] <= limit)
            {
                next = list[list.Count - 1] + list[list.Count - 2];
                list.Add(next);
                i++;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static void Main()
        {
            PrintFibonacciUpTo();
        }
    }
}