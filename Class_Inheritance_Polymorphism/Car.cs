using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Car : Vehicle
    {
        public Car()
        {
            MaxPassengers = 4;
            CreatePassengers(4);
        }
    }
}
