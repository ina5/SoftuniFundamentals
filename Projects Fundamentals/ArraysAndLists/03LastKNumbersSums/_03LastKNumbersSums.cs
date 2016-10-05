using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LastKNumbersSums
{
    class _03LastKNumbersSums
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            for (long current = 1; current < arr.Length; current++)
            {
                long result1 = Math.Max(0, current - k);
                long result2 = current - 1;
                long sum = 0;
                for (long previous = result1; previous <= result2; previous++)
                {
                    sum += arr[previous];
                }
                arr[current] = sum;
            }
            for (long i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
