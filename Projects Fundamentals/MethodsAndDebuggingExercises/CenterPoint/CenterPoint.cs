using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var distance1 =ComparePoints(x1, y1);
            var distance2 = ComparePoints(x2, y2);
            var list = new List<double>(2);
            if (distance1 > distance2)
            {
                list.Add(x2);
                list.Add(y2);
            }
            else
            {
                list.Add(x1);
                list.Add(y1);
            }

            Console.Write("(");
            Console.Write(String.Join(", ", list));
            Console.WriteLine(")");
        }
        static double ComparePoints(double x, double y)
        {
            var distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
           
        }
    
    }
}



