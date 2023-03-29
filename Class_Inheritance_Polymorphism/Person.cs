using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Person
    {
        string FirstName;
        string SurName;
        byte Age;

        public Person(string firstName, string surName, byte age)
        {
            FirstName = firstName;
            SurName = surName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {SurName}, {Age} years";
        }
    }
}
