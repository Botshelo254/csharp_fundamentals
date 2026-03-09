using System;

namespace Day1
{
    class Program
    {
        static void ReverseNumber()
        {
            int number = int.Parse(Console.ReadLine());

            string digit = number.ToString();

            string reverseDigit = string.Empty;

            for (int i = 0; i < digit.Length; i++)
                reverseDigit = digit[i] + reverseDigit;

            Console.Write(reverseDigit);
        }

        static void Main()
        {
            ReverseNumber();
        }
    }
}