using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3OddOccurrences
{
    class _3OddOccurrences
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().Split();
            var dictResult = new Dictionary<string, int>();
            foreach (var word in inputWords)
            {
                if (dictResult.ContainsKey(word.ToLower()))
                {
                    dictResult[word.ToLower()]++;
                }
                else
                {
                    dictResult.Add(word.ToLower(), 1);
                }
            }
            var result = new List<string>();
            foreach (var item in dictResult)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

