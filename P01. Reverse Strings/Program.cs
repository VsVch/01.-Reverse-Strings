using System;
using System.Linq;

namespace P01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {

                string revers = new string(word.Reverse().ToArray());
                Console.WriteLine($"{word} = {revers}");
                word = Console.ReadLine();
            }
        }
    }
}
