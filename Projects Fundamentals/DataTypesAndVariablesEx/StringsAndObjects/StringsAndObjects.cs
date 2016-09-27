using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstS = "Hello";
            string secondS = "World";
            //string resultS = "";
            object greeting = firstS + " " + secondS;
            string castedGreeting = (string)greeting;
            Console.WriteLine(castedGreeting);
        }
    }
}
