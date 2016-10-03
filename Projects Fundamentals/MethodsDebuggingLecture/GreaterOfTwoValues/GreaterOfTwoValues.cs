using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstCh = char.Parse(Console.ReadLine());
                char secondCh = char.Parse(Console.ReadLine());
                char max = GetMax(firstCh, secondCh);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                string max = GetMax(firstStr, secondStr);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int first, int second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }
        static char GetMax(char first, char second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }
    }
}
