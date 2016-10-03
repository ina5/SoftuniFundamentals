using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (isPalindrome(i) == true && SumOfDigits(i) == true && EvenDigits(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool isPalindrome(int number)
        {
            string numberStr = number.ToString();
            if (numberStr.Length < 4 && numberStr[0] == numberStr[numberStr.Length - 1])
            {
                return true;
            }
            else if (numberStr.Length < 6 &&
                (numberStr[0] == numberStr[numberStr.Length - 1] && numberStr[1] == numberStr[numberStr.Length - 2]))
            {
                return true;
            }
            else if (numberStr.Length < 8 &&
               (numberStr[0] == numberStr[numberStr.Length - 1] && numberStr[1] == numberStr[numberStr.Length - 2]
               && numberStr[2] == numberStr[numberStr.Length - 3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SumOfDigits(int number)
        {
            string numberStr = number.ToString();
            int sumOfDigits = 0;
            for (int i = 0; i < numberStr.Length; i++)
            {
                sumOfDigits += int.Parse(numberStr[i].ToString());
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EvenDigits(int number)
        {
            string numberStr = number.ToString();
            int evenCounter = 0;
            for (int i = 0; i < numberStr.Length; i++)
            {
                int currentDigit = int.Parse(numberStr[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
