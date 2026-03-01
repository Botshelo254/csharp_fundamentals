namespace Day1
{
    class Program
    {
        static void Main()
        {
            string s = System.Console.ReadLine();
            int countVowels = 0;

            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    countVowels += 1;

                i++;
            }

            System.Console.Write(countVowels);
        }
    }
}