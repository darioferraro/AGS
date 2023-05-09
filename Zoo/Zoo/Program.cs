namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ape cheeta = new Ape("cheeta", 3);
            cheeta.walk();
            cheeta.climbing();
            
            Console.WriteLine("*********************");
            Elefant dumbo = new Elefant("dumbo", 29);
            dumbo.walk();   
            dumbo.trumpet();


            Console.WriteLine("*********************");
            Console.WriteLine("animal referenziert auf cheeta");
            Animal animal = cheeta;
            animal.walk();

            Console.WriteLine("*********************");
            animal = dumbo;
            animal.walk();

            Zoo basel = new Zoo("Basel");
            basel.Add(dumbo);
            basel.Add(cheeta);

            basel.WalkWithAllAnimals();
            basel.FeedTheAnimals();

            dumbo.trumpet(3);
            cheeta.climbing(true); 



            // Animal whatever = new Animal("nobody", -1);

        }
    }
}