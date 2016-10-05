using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16CountNumbers
{
    class _16CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count-1) // last case
                {
                    Console.WriteLine(numbers[i] + " -> " + count);
                    break;
                }

                if (numbers[i] == numbers[i+1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(numbers[i]+" -> " + count);
                    count = 1;
                }
            }
        }
    }
}
