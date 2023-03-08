using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class BMW : Car
    {
        public BMW()
        {
            this.TopSpeed = 200;
            this.Model = "BMW";
        }

        public override void HonkHorn()
        {
            Console.WriteLine("Beep beep! I am a BMW.");
        }
    }
}
