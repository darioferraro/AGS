using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Elefant : Animal
    {
        public void trumpet()
        {
            Console.WriteLine("{0} trumpets loud!", Name);
        }

        public void trumpet(int count)
        {
            for(int i=0; i<count; i++) {
                trumpet();
            }
        }

        public override void walk()
        {
             base.walk();
            trumpet();

        }

        public override void eat()
        {
            Console.WriteLine("Peanut mmpf");

        }
        public Elefant(string name, byte age) : base(name, age)
        {

        }
    }
}
