using System;
using System.Globalization;

namespace Day1
{
    class Program
    {
        static void CalculateSimpleInterest()
        {
            double p = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            double si = (p * r * t) / 100;

            Console.Write(si.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Main()
        {
            CalculateSimpleInterest();
        }
    }
}