using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string expresion = Console.ReadLine();
            
           
            while (expresion.Contains(word))
            {
               
               expresion = expresion.Replace(word, "");
            }
            Console.WriteLine(expresion);
        }
    }
}
