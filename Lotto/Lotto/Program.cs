namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\Lottoziehung.txt";
            Lottoziehung lottoziehung = new Lottoziehung(filePath);
            lottoziehung.ZahlenGenerieren();
            Console.WriteLine (lottoziehung.ZahlenToString());
            lottoziehung.ZahlenToFile();
            lottoziehung.ZahlenToFile(false);
        }
    }
}