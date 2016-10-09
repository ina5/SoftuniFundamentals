using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Phonebook
{
    class _1Phonebook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input != "END")
            {
                string[] inputSplit = input.Split(' ').ToArray();
                if (inputSplit[0] == "S")
                {
                    if (!phonebook.ContainsKey(inputSplit[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", inputSplit[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", inputSplit[1], phonebook[inputSplit[1]]);
                    }
                }
                else
                {
                    phonebook[inputSplit[1]] = inputSplit[2];
                }
                input = Console.ReadLine();
            }
        }
    }
}

