using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RoundingNumbers
{
    class _05RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "=> " + (int)Math.Round(arr[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
