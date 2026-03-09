using System;

namespace Day1
{
    class Program
    {
        static void PrintNestedPattern()
        {
            int size = int.Parse(Console.ReadLine());

            int row = 1;
            while (row <= size)
            {
                int col = 1;
                while (col <= size)
                {
                    Console.Write(row);
                    Console.Write(' ');
                    col++;
                }
                Console.Write('\n');
                row++;
            }
        }

        static void Main()
        {
            PrintNestedPattern();
        }
    }
}