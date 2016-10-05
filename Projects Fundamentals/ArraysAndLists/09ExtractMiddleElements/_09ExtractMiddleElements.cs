using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExtractMiddleElements
{
    class _09ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();

            int middle = numbers.Length / 2;

            if (numbers.Length == 1)
                Console.WriteLine(numbers[0]);
            else if (numbers.Length % 2 == 0)
                Console.WriteLine($"{numbers[middle - 1]}, {numbers[middle]}");
            else
                Console.WriteLine($"{numbers[middle - 1]}, {numbers[middle]}, {numbers[middle + 1]}");
        }
    }
}
