using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Ape : Animal
    {
        public override void  walk()
        {
            base.walk();
            climbing();

        }

        public void climbing()
        {
            Console.WriteLine("I am swinging throug the trees!");

        }

        public void climbing(bool careful)
        {
            if (careful) { 
                Console.WriteLine("I am swinging throug the trees with my baby ape!");
            }
            else {
                climbing();
            }
        }

        public override void eat()
        {
            Console.WriteLine("Bananaaa uuh");

        }
        public Ape(string name, byte age) : base(name, age) 
        {

        }
    }
}
