using System;
using System.Globalization;

namespace Day1
{
    class Program
    {
        static void CalculateArrayStats()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum: " + sum);

            double average = sum / arr.Length;

            Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Main()
        {
            CalculateArrayStats();
        }
    }
}
