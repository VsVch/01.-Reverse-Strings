using System;

namespace P02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string res = string.Empty;
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    res += word;
                }

            }
            Console.WriteLine(res);
        }
    }
}
