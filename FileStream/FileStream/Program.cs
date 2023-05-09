using System;
using System.IO;
using System.Text;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\tmp\Stream.txt";
            string text = "X";
            string text2 = "What the hell";

            using( FileStream fs = File.OpenWrite(filename) )
            {
                byte[] info = new UTF8Encoding().GetBytes(text);
                // In die Datei schreiben
                fs.Seek(-16, SeekOrigin.End);
                fs.Write(info, 0, info.Length);
                fs.Seek(0, SeekOrigin.Begin);
                info = new UTF8Encoding().GetBytes(text2);
                fs.Write(info, 0, info.Length);
                
                // nach 10 Zeichen wird der Inhalt überschrieben
            } // --> hier wird Dispose aufgerufen
        }
    }
}
