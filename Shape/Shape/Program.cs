namespace Shape
{
    abstract class Shape
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public ConsoleColor Color { get; set; }
        public abstract void Draw();
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // Zeichnen simulieren ;-)
            Console.WriteLine("Zeichne Rechteck");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Kreis");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Dreieck");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // geht nicht
            // Shape shape = new Shape();

            Shape shape = new Triangle();
            shape.Draw();

            shape = new Circle();
            shape.Draw();

            shape = new Rectangle();
            shape.Draw();

        }
    }
}