using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Lottoziehung
    {
        private string filePath;
        private int length;
        private Random random;

        public int[] ZahlenGenerieren()
        {
            int number = 0;
            int[] lottozahlen = new int[length];    
           
            for (int i = 0; i < length; i++)
            {
                number = random.Next(49);
                lottozahlen[i] = number;
            }
            return lottozahlen;
          
        }

        public string ZahlenToString()
        {
            int[] lottozahlen = ZahlenGenerieren();
            string zahlen = "";
            for (int i = 0; i < length; i++)
            {
                zahlen += lottozahlen[i];
                if (i < length -1)
                    zahlen += ";";

            }

            return zahlen;
        }

        public void ZahlenToFile(bool show=true)
        {
            using (StreamWriter fs = new StreamWriter(filePath, append: true))
            {
                string numbers = ZahlenToString();
                if (show)
                {
                    Console.WriteLine(numbers); 
                }
                fs.WriteLine(numbers);
            }
        }

        public Lottoziehung(string filePath,int length = 6)
        {
            this.filePath = filePath;
            random = new Random();
            this.length = length;
        }
    }
}
