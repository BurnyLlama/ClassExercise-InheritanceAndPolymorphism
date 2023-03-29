using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            MaxPassengers = 2;
            CreatePassengers(2);
        }
    }
}
