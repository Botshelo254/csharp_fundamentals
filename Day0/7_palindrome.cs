using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            string str = System.Console.ReadLine();
            string newStr = str.Replace(" ", "");
            string reversed = new string(newStr.Reverse().ToArray());

            if (newStr.ToLower() == reversed.ToLower())
                System.Console.WriteLine("Palindrome");
            else
                System.Console.Write("Not a Palindrome");
        }
    }
}