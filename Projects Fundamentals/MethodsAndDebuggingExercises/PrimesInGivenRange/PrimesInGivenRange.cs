using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", PrimeNumbersInRange(num1, num2).ToArray());

            Console.WriteLine(numbers);
        }
        public static bool IsPrime(int number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;
            int half = number / 2;
            for (int i = 2; i <= half; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static List<int> PrimeNumbersInRange(int num1, int num2)
        {
            List<int> numbers = new List<int>();
            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }
}
