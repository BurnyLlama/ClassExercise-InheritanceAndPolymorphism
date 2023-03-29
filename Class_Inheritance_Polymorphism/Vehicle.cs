using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Vehicle
    {
        public Random Rand;
        public int TopSpeed;
        public int CurrentSpeed;
        public int ChangeInSpeed;
        
        public string Model;
        public bool IsParked;

        protected Person[] Passengers;
        protected int MaxPassengers;

        public readonly int ID;

        public Vehicle() 
        {
            TopSpeed = 60;
            CurrentSpeed = 0;

            Model = "No Model";
            IsParked = false;

            MaxPassengers = 1;
            Passengers = new Person[MaxPassengers];

            // This will maybe cause errors in about one and a half decade...
            // https://en.wikipedia.org/wiki/Year_2038_problem
            int uniqueSeed = (int) DateTime.Now.ToBinary();
            Rand = new Random(uniqueSeed);

            ID = Rand.Next();
        }

        public void Accelerate()
        {
            ChangeInSpeed = Rand.Next(1, TopSpeed);
            int newSpeed = CurrentSpeed + ChangeInSpeed;
            CurrentSpeed = Math.Min(newSpeed, TopSpeed);
            ShowCurrentSpeed();
        }

        public void Decelerate()
        {
            ChangeInSpeed = Rand.Next(1, TopSpeed);
            int newSpeed = CurrentSpeed - ChangeInSpeed;
            CurrentSpeed = Math.Max(newSpeed, 0);
            ShowCurrentSpeed();
        }

        public void ShowCurrentSpeed()
        {
            Console.WriteLine($"{Model} is going {CurrentSpeed} km/h");
        }

        public virtual void HonkHorn()
        {
            Console.WriteLine($"{Model} honked the horn!");
        }

        public void CreatePassengers(uint passengerAmount)
        {
            if (passengerAmount > MaxPassengers)
            {
                throw new ArgumentOutOfRangeException("Too many passengers!");
            }

            Person[] passengers = PassengerGenerator.Create(passengerAmount);
            Passengers = passengers;
        }

        public Person[] GetPassengers()
        {
            return Passengers;
        }

        public void ShowPassengers()
        {
            Console.WriteLine( "------------------------");
            Console.WriteLine($"Passengers in {Model}:");
            Console.WriteLine( "------------------------");
            for (int i = 0; i < Passengers.Length; i++)
            {
                Console.WriteLine($" {i+1}. {Passengers[i]}");
            }
            Console.WriteLine("------------------------\n");
        }
    }
}
