using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string resCombined = string.Concat(Enumerable.Reverse(string.Concat(a, b, c)));
            Console.WriteLine(resCombined);
        }
    }
}
