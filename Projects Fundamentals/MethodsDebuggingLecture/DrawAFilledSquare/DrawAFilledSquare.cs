using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("-");
                    Console.Write("\\/");

                    Console.WriteLine("-");
                }


                Console.WriteLine(new string('-', 2 * n));

            }

        }
    }
}
