using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Honda : Motorcycle
    {
        public Honda()
        {
            this.Model = "Honda";
        }

        public override void HonkHorn()
        {
            Console.WriteLine("Dep dep! I am a Honda.");
        }
    }
}
