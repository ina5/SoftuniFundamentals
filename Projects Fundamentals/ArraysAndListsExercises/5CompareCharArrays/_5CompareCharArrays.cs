using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CompareCharArrays
{
    class _5CompareCharArrays
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int length = Math.Min(firstArray.Length, secondArray.Length);

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }

            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                    else if (secondArray[i] > firstArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                }
            }
        }
    }
}
