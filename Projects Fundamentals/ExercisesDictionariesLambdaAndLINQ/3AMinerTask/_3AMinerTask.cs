using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AMinerTask
{
    class _3AMinerTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while (input != "stop")
            {
                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] += number;
                }
                else
                {
                    dictionary.Add(input, number);
                }
                input = Console.ReadLine();
                if (input.Equals("stop"))
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
