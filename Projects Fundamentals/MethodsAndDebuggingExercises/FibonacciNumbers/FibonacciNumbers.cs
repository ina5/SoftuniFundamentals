using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));

        }
        public static int Fibonacci(int n)
        {

            int a = 1;
            int b = 1;
            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }
}

