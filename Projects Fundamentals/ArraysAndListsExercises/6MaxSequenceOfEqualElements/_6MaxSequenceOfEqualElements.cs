using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6MaxSequenceOfEqualElements
{
    class _6MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lenght = 1;
            int lenghtBest = 1;
            int start = 0;
            int startBest = 0;

            for (int position = 1; position < numbers.Count; position++)
            {
                if (numbers[position] == numbers[position - 1])
                {
                    lenght++;
                }
                else if (numbers[position] != numbers[position - 1])
                {
                    start = position;
                    lenght = 1;
                }
                if (lenght > lenghtBest)
                {
                    lenghtBest = lenght;
                    startBest = start;
                }


            }
            var numbersResult = numbers.GetRange(startBest, lenghtBest);
            Console.WriteLine(string.Join(" ", numbersResult));

        }

    }
}

