﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {


            // Console.Write("Length: ");
            //double lenght = double.Parse(Console.ReadLine());
            // Console.Write("Width: ");
            // double width = double.Parse(Console.ReadLine());
            // Console.Write("Height: ");
            //double height = double.Parse(Console.ReadLine());
            //double v = (lenght * width * height) / 3;
            // Console.WriteLine("Pyramid Volume: {0:F2}", v);

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);


        }
    }
}
