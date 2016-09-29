﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetEvensAndOdds(n));
        }
        static int GetEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            int sum = sumEvens * sumOdds;
            return sum;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sumEvens = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvens += lastDigit;
                }
                n /= 10;

            }
            return sumEvens;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sumOdds = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdds += lastDigit;
                }
                n /= 10;
            }
            return sumOdds;
        }
    }
}

