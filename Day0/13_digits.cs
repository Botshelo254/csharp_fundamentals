namespace Day1
{
    class Program
    {
        static void Main()
        {
            int digits = int.Parse(System.Console.ReadLine());

            string number = digits.ToString();

            System.Console.Write(number.Length);
        }
    }
}