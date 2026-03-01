namespace Day1
{
    class Program
    {
        static void Main()
        {
            string str = System.Console.ReadLine().Trim();
            int countWords = 1;

            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == ' ')
                    countWords += 1;
                
                i++;
            }


            System.Console.Write(countWords);
        }
    }
}