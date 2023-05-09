using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        private string name;
        private byte age;

        public string Name { get => name;  }


        public byte Age { get=> age; set => age = value; }  


        public virtual void walk()
        {
            Console.WriteLine("Name:\t{0}", Name);
            Console.WriteLine("Age:\t{0}", Age);
            Console.WriteLine("I am walking", Name);

        }

        public abstract void eat();

        public Animal (string name, byte age)
        {
            this.name = name;
            this.age = age;
        }




    }
}
