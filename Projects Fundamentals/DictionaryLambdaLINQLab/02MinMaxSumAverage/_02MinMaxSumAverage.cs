using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MinMaxSumAverage
{
    class _02MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            double avg=0;
            double max=0;
            double min=0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
               nums [i] =  int.Parse(Console.ReadLine());
              avg = (double)nums.Average();
              max = (double)nums.Max();
              min = (double)nums.Min();
              sum = (double)nums.Sum();
            }
            Console.WriteLine("Sum = {0} \nMin = {1} \nMax = {2} \nAverage = {3}", sum, min, max, avg);

        }
       
    }
}
