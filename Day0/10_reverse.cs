using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            string str = System.Console.ReadLine();
            string newStr = str.Trim();
            string reversed = new string(newStr.Reverse().ToArray());

            System.Console.Write(reversed);
        }
    }
}