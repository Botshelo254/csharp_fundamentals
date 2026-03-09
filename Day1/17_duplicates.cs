using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void FindDuplicates()
        {
            int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> duplicates = new List<int>();

            var result = list.GroupBy(item => item).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Count() > 1)
                {
                    duplicates.Add(result[i].Key);
                }
            }

            for (int i = 0; i < duplicates.Count; i++)
            {
                Console.Write(duplicates[i] + " ");
            }
        }

        static void Main()
        {
            FindDuplicates();
        }
    }
}