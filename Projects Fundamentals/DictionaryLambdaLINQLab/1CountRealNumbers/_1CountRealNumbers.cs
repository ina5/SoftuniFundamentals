using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CountRealNumbers
{
    class _1CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var counts = new SortedDictionary<double, int>();

            foreach (var num in nums)
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;

            foreach (var num in counts.Keys)
                Console.WriteLine($"{num} -> {counts[num]}");


            //Another way to print the value in dictionary
            //foreach (KeyValuePair<double,int> num in counts)
            //{
            //    Console.WriteLine(num.Value);
            //}
        }
    }
}
