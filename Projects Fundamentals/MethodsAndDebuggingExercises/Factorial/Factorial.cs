using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
           BigInteger numberFactorial = int.Parse(Console.ReadLine());

            Console.WriteLine(IsFactorial(numberFactorial));
        }
        static BigInteger IsFactorial(BigInteger numberFactorial)
        {
            BigInteger result = numberFactorial;

            for (BigInteger i = 1; i < numberFactorial; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
