using System;

namespace Day1
{
    class Program
    {
        static void CalculatePower()
        {
            int @base = int.Parse(Console.ReadLine());
            int exponent  = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(@base, exponent);

            Console.Write(result);
        }

        static void Main()
        {
            CalculatePower();
        }
    }
}