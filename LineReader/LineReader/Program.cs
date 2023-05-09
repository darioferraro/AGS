namespace LineReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = @"..\..\..\myText.txt";
            string filePath= @"..\..\..\myWriteText.txt";

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            string[] lines = { "Dies ist die erste Zeile", "Dies ist die zweite Zeile", "Dies ist die dritte Zeile" };

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }


        }
    }
}