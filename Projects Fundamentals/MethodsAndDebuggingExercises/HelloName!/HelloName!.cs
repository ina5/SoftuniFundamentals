using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName_
{
    class HelloName_
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
            
        }
        static void GetName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
