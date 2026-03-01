using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int> {0, 1};
            int number = int.Parse(System.Console.ReadLine());
            int next;

            int i = 2;
            while (i <= number)
            {
                next = list[list.Count - 1] + list[list.Count - 2];
                list.Add(next);
                i++;
            }

            int count = 0;
            while (count < list.Count - 1)
            {
                System.Console.Write(list[count] + " ");
                count++;
            }
        }
    }
}