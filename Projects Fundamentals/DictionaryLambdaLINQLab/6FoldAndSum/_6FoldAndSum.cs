using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6FoldAndSum
{
    class _6FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            int[] firstFold = new int[numbers.Length / 2];
            int[] secondFold = new int[numbers.Length / 2];
            int n = 0;
            for (int i = numbers.Length / 4 - 1; i >= 0; i--)
            {
                firstFold[n] = numbers[i];
                n++;
            }
            n = numbers.Length / 2 - 1;
            for (int i = numbers.Length - numbers.Length / 4; i < numbers.Length; i++)
            {
                firstFold[n] = numbers[i];
                n--;
            }
            n = 0;
            int start = numbers.Length / 4;
            int end = numbers.Length - numbers.Length / 4;
            for (int i = start; i < end; i++)
            {
                secondFold[n] = numbers[i];
                n++;
            }
            int[] sum = new int[firstFold.Length];
            for (int i = 0; i < firstFold.Length; i++)
            {
                sum[i] = firstFold[i] + secondFold[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
