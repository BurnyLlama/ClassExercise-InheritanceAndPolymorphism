using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class HarleyDavidson : Motorcycle
    {
        public HarleyDavidson() {
            this.Model = "Harley Davidson";
        }

        public override void HonkHorn()
        {
            Console.WriteLine("Toooot! I am a Harley Davidson.");
        }
    }
}
