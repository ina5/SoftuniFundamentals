using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PhonebookUpgrade
{
    class _2PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            Dictionary<string, string> result = new Dictionary<string, string>();
            while (input != "END")
            {
                while (input != "ListAll")
                {
                    string[] parts = input.Split(' ');
                    dictionary.Add(parts[1], parts[2]);
                    input = Console.ReadLine();
                }
                foreach (var key in dictionary)
                {
                    result.Add(key.Key, key.Value);
                }
                dictionary.Clear();
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}

