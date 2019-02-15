using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_demonstrator
{
    class Person
    {
        public string FirstName;
        public string SecondName;

        public void SayName()
        {
            Console.WriteLine(FirstName + " " + SecondName);
        }
    }
}
