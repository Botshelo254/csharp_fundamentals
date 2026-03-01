using System.Globalization;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            float b = float.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            float c = float.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            float average = (a + b + c) / 3;

            System.Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}