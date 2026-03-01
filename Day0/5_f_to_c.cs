using System.Globalization;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            float f = float.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            float c = (f - 32) * 5 / 9;

            System.Console.Write("Celsius: " + c.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}