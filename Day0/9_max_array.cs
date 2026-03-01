using System.Globalization;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            int[] arr = System.Array.ConvertAll(System.Console.ReadLine().Split(' '), int.Parse);

            int i = 0;
            while (i < arr.Length - 1)
            {
                int j = 0;
                while (j < arr.Length - 1)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    j++;
                }
                i++;
            }

            System.Console.Write("Max: " + arr[0]);
        }
    }
}