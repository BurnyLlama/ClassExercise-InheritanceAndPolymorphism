using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Volvo : Car
    {
        public Volvo() {
            this.TopSpeed = 200;
            this.Model = "Volvo";
        }

        public override void HonkHorn()
        {
            Console.WriteLine("Boop boop! I am a Volvo.");
        }
    }
}
