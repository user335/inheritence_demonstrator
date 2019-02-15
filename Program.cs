using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_demonstrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Sample";
            newEmployee.SecondName = "Student";
            newEmployee.SayName();
            Console.ReadKey();
        }
    }
}
