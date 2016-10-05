using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReverseArrayOfIntegers
{
    class _02ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());

            }
            for (int i = arrayNum.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayNum[i]);
            }


        }
    }
}
