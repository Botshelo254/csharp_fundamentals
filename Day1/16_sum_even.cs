using System;

namespace Day1
{
    class Program
    {
        static void SumEvenNumbers()
        {
            int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                    sum = sum + list[i];
            }

            Console.Write(sum);
        }

        static void Main()
        {
            SumEvenNumbers();
        }
    }
}