using System;

namespace Day1
{
    class Program
    {
        static void CompareStrings()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string s1 = str1.ToLower().Trim();
            string s2 = str2.ToLower().Trim();

            if (s1 == s2)
                Console.Write("Strings are equal");
            else
                Console.Write("Strings are not equal");
        }

        static void Main()
        {
            CompareStrings();
        }
    }
}