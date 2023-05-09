namespace FileException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = @"c:\tmp\test.txt";
            string[] existingText;
            try
            {
                existingText = File.ReadAllLines(filename);
                Console.WriteLine(existingText[0]);
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("Leider hast du keinen Zugriff auf die Datei. Sicherheitsgründe …");
             return;
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Wow, der Pfad muss ja wirklich lang sein!");
                return;
            }
            catch (IOException)
            {
                Console.WriteLine("Uiuiui, ein allgemeiner Lesefehler.");
                return;
            };
        }
    }
}