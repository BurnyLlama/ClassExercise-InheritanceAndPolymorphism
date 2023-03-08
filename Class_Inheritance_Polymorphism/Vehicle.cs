using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Vehicle
    {
        public int TopSpeed;
        public int CurrentSpeed;
        public int ChangeInSpeed;
        public string Model;
        public Random Rand;
        public bool IsParked;

        public readonly int ID;

        public Vehicle() 
        {
            TopSpeed = 60;
            CurrentSpeed = 0;
            Model = "No Model";
            IsParked = false;

            // This will maybe cause errors in about one and a half decade...
            // https://en.wikipedia.org/wiki/Year_2038_problem
            int uniqueSeed = (int) DateTime.Now.ToBinary();
            this.Rand = new Random(uniqueSeed);

            this.ID = this.Rand.Next();
        }

        public void Accelerate()
        {
            this.ChangeInSpeed = Rand.Next(1, this.TopSpeed);
            int newSpeed = this.CurrentSpeed + this.ChangeInSpeed;
            this.CurrentSpeed = Math.Min(newSpeed, this.TopSpeed);
            this.ShowCurrentSpeed();
        }

        public void Decelerate()
        {
            this.ChangeInSpeed = Rand.Next(1, this.TopSpeed);
            int newSpeed = this.CurrentSpeed - this.ChangeInSpeed;
            this.CurrentSpeed = Math.Max(newSpeed, 0);
            this.ShowCurrentSpeed();
        }

        public void ShowCurrentSpeed()
        {
            Console.WriteLine($"{this.Model} is going {this.CurrentSpeed} km/h");
        }

        public virtual void HonkHorn()
        {
            Console.WriteLine($"{this.Model} honked the horn!");
        }
    }
}
