using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PairsByDifference
{
    class _10PairsByDifference
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == n)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
