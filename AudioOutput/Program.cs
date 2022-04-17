using System;
using System.Threading;

namespace AudioOutput
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zvukový výstup");
            Console.WriteLine("--------------");

            double toneBase = 65.406;
            string[] toneName = { "c2", "cis2", "d2", "dis2", "e2", "f2", "fis2", "g2", "gis2", "a2", "b2", "h2", "c3" };
            int[] toneFrequency = new int[13];
            double c2 = toneBase * Math.Pow(2, 3);

            for (int i = 0; i <= 12; i++)
            {
                toneFrequency[i] = (int)Math.Round(c2 * Math.Pow((Math.Pow(2, (1.0 / 12.0))), i));
                Console.WriteLine("Tón {0,-4} o frekvenci {1,4} Hz", toneName[i], toneFrequency[i]);
                Console.Beep(toneFrequency[i], 500);
            }

            Thread.Sleep(2000);
            Console.WriteLine("Console.Beep();");
            Console.Beep();

            Thread.Sleep(2000);
            Console.WriteLine("(char)7" + (char)7);
        }
    }
}
