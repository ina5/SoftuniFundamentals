using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11AppendLists
{
    class _11AppendLists
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
