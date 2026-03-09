using System;

namespace Day1
{
    class Program
    {
        static void SwapNumbers()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: a={a}, b={b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After: a={a}, b={b}");
        }

        static void Main()
        {
            SwapNumbers();
        }
    }
}