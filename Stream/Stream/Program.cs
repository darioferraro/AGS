using System.IO;
using System.Text;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tmp\random.csv";
            Random random= new Random();


            using (StreamWriter fs = new StreamWriter(path,append: true))
            {
                int number = 0, length = 6;
                do
                {
                    for (int i = 0; i < length; i++)
                    {
                        number = random.Next(49);
                        Console.Write(number);
                        Console.Write(";");
                        fs.Write(number);
                        fs.Write(";");

                    }
                    Console.WriteLine();
                    fs.Write("\n");




                } while (Console.ReadKey().Key != ConsoleKey.A);

                
            }
        }

    }
}