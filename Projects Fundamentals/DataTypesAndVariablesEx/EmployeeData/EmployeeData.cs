using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string idNumber = Console.ReadLine();
            string eNumber = Console.ReadLine();
            Console.WriteLine("First name: {0} \n Last name: {1} \n Age: {2} \n Gender: {3} \n Personal ID: {4} \n Unique Employee number: {5}", fName, lName, age, gender, idNumber, eNumber);

        }
    }
}
