namespace FileManipulationen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.IO.File.WriteAllText("..\\..\\..\\meineDatei.txt", "overwrite plz");
            String text = System.IO.File.ReadAllText("..\\..\\..\\meineDatei.txt");
            System.IO.File.AppendAllText("..\\..\\..\\meineDatei.txt", "\nneuer Text plz");
            text = System.IO.File.ReadAllText("..\\..\\..\\meineDatei.txt");

            Console.WriteLine(text);
        }
    }
}