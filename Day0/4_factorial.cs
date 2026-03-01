namespace Day1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(System.Console.ReadLine());
            int factorial = 1;

            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            System.Console.Write(number + "! = " + factorial);
        }
    }
}