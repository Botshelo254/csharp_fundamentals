using System;

namespace Day1
{
    class Program
    {
        static void LinearSearch()
        {
            int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int number = int.Parse(Console.ReadLine());

            int times = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == number)
                    times = times + 1;
            }

            Console.Write(times);
        }

        static void Main()
        {
            LinearSearch();
        }
    }
}