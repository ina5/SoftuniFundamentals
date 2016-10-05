using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SplitByWordCasing
{
    class _13SplitByWordCasing
    {

        static void Main(string[] args)
        {
            var inputCust = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var input = Console.ReadLine().Split(inputCust, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            for (var i = 0; i < input.Count; i++)
            {
                bool isLowerCase = true;
                bool isUpperCase = true;

                for (int j = 0; j < input[i].Length; j++)
                {
                    if (char.IsLower(input[i][j]))
                    {
                        isLowerCase = false;
                    }
                    else if (char.IsUpper(input[i][j]))
                    {
                        isUpperCase = false;
                    }
                    else
                    {
                        isLowerCase = false;
                        isUpperCase = false;
                    }
                }
                if (isLowerCase)
                {
                    lowerCase.Add(input[i]);
                }
                else if (isUpperCase)
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }


            Console.WriteLine("Lower-case: {0}", string.Join(", ", upperCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", lowerCase));
        }
    }
}