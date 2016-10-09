using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2RotateAndSum
{
    class _2RotateAndSum
    {
        static void Main(string[] args)
        {

            //WORKIN FOR ONE ROTATION:
            //{  int[] demo = new int[numbers.Length];

            //        for (int j = 0; j < numbers.Length; j++)
            //        {
            //            demo[(j + 1) % demo.Length] = numbers[j];
            //        }
            //   Console.WriteLine("{0}", string.Join(", ", demo));


            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToRotate = int.Parse(Console.ReadLine());
            var sum = new int[numbers.Length];
            for (int i = 0; i < numberToRotate % numbers.Length-1; i++)
            {
                int temp = numbers[0];
                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                 
                }

                numbers[numbers.Length - 1] = temp;

            }

            Console.WriteLine(string.Join(" ", numbers));

        }

    }
}
