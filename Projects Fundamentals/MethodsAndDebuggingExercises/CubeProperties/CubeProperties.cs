using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double lenght = 0;
            Console.WriteLine(LenghtOfTheDiagonals(lenght,sideCube,parameter));

        }
        static double LenghtOfTheDiagonals(double leght, double sideCube, string parameter)
        {
            if (parameter == "face")
            { 
                leght = Math.Sqrt(2 * (sideCube * sideCube));
            }
          else  if (parameter == "space")
            {
                leght = Math.Sqrt(3 * (sideCube * sideCube));
            }
            else if (parameter == "volume")
            {
                leght = Math.Pow(sideCube,3);
            }
            else if (parameter == "area")
            { 
                leght = 6 * (sideCube * sideCube);
            }
            return Math.Round(leght,2);
        }
    }
}
