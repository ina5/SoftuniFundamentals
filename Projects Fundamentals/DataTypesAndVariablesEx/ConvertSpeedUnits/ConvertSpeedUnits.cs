using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours =    float.Parse(Console.ReadLine());
            float minutes =  float.Parse(Console.ReadLine());
            float seconds =  float.Parse(Console.ReadLine());

            float metersSec = (hours + minutes / 60 + seconds / 3600) / 3.6f;
            float kmHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float milesHour = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);
            Console.WriteLine("{0} \n{1} \n{2}", metersSec, kmHour, milesHour);
        }
    }
}
