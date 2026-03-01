namespace Day1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(System.Console.ReadLine());

            if (number % 2 == 0)
                System.Console.Write("Even");
            else
                System.Console.Write("Odd");
        }
    }
}