using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                PrintTriangle(1, i);
            }
            // PrintTriangle(1, num); спестява време и MB-и
            for (int i = num - 1; i >= 0; i--)
            {
                PrintTriangle(1, i);
            }
        }
        static void PrintTriangle(int start, int end)
        {

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
    }
}
