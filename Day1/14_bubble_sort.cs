using System;

namespace Day1
{
    class Program
    {
        static void BubbleSort()
        {
            int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            Console.Write(string.Join(" ", list));
        }

        static void Main()
        {
            BubbleSort();
        }
    }
}