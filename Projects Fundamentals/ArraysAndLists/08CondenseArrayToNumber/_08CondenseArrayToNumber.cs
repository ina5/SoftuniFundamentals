using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CondenseArrayToNumber
{
    class _08CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(number, int.Parse);

            int[] condense = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < condense.Length - i; j++)
                {
                    condense[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condense;
            }
            Console.WriteLine(condense[0]);
        }
    }
}
