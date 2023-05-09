using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Zoo
    {


        private List<Animal> animals;
        private string name;

        public void Add(Animal animal)
        {
            animals.Add(animal);    
        }

        public void FeedTheAnimals()
        {
            Console.WriteLine("**************");
            Console.WriteLine("{0}: Feed all animals!!!",name);
            Console.WriteLine("**************");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.eat();
            }
        }

        public void WalkWithAllAnimals()
        {
            Console.WriteLine("**************");
            Console.WriteLine(name);
            Console.WriteLine("**************");

            foreach (Animal animal in animals)
            {
                animal.walk();
            }
        }

        public Zoo(string name) 
        {
            animals = new List<Animal>();   
            this.name = name;   
        }
    }
}
