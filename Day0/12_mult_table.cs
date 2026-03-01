namespace Day1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(System.Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                System.Console.WriteLine(number + " x " + i + " = " + (number * i));
                i++;
            }
        }
    }
}