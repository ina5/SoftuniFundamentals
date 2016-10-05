using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SumAdjacentEqualNumbers
{
    class _12SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
               
                    if (numbers[i] == numbers[i+1]);
                sum = numbers[i] + numbers[i];
            } 
          
        }
    }
}


