using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ReverseArrayOfStrings
{
    class _06ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string [] word = Console.ReadLine().Split(' ');
            Array.Reverse(word);
            foreach (string item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}
