namespace Day1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(System.Console.ReadLine());

            if (number < 2)
            {
                System.Console.Write("Not Prime");
                return;
            }

            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    System.Console.Write("Not Prime");
                    return;
                }
                i++;
            }

            System.Console.Write("Prime");
        }
    }
}