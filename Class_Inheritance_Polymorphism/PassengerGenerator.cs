using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal static class PassengerGenerator
    {
        public static Person[] Create(uint passengerAmount)
        {
            if (passengerAmount == 0)
            {
                return new Person[0];
            }

            Person[] passengers = new Person[passengerAmount];
            for (int i = 0; i < passengerAmount; i++)
            {
                string firstName = IdentityGenerator.FirstName();
                string surName = IdentityGenerator.SurName();
                byte age = IdentityGenerator.Age();

                passengers[i] = new Person(firstName, surName, age);
            }

            return passengers;
        }
    }
}
