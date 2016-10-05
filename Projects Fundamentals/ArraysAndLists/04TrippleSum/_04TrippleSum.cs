using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TrippleSum
{
    class _04TrippleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            bool check = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int b = arr[j];
                    int sum = a + b;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        check = false;
                    }

                }

            }
            if (check)
            {
                Console.WriteLine("No");
            }
        }
    }
}
