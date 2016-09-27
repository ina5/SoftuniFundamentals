using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digitSum = 0;
            int j = 0;
            bool result = false;
            for (int i = 1; i <= n; i++)
            {
                j = i;
                while (i > 0)
                {
                    digitSum += i % 10;
                    i = i / 10;
                }
                result = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                Console.WriteLine($"{j} -> {result}");
                digitSum = 0;
                i = j;
            }


        }
    }
}
