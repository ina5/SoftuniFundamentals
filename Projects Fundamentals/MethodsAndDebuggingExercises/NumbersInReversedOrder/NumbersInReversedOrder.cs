using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
        string num = Console.ReadLine();
            Console.WriteLine(GetReverseDigits(num));
        }
        public static string GetReverseDigits(string num)
        {
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
