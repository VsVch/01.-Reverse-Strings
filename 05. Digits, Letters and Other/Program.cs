using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = new StringBuilder();
            var lets = new StringBuilder();
            var oths = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {


                var charInput = input[i];
                if (char.IsDigit(charInput))
                {
                    nums.Append(charInput);
                }
                else if (char.IsLetter(charInput))
                {
                    lets.Append(charInput);
                }
                else
                {
                    oths.Append(charInput);
                }




            }

            Console.WriteLine(nums);
            Console.WriteLine(lets);
            Console.WriteLine(oths);

        }
    }
}
