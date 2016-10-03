using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(num3, GetMax(num1, num2)));
        }
        static int GetMax (int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
            
        }
    }
}
