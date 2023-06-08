using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND2_OOPSPrograms
{
    internal class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
    }
}
