using System;

namespace ZvukovyVystup
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zvukový výstup");
            Console.Write((char)7);
            Klavesa();
            Console.Beep();
            Klavesa();

            double zakladniTon = 65.406;
            string[] nazevTonu = { "c2", "cis2", "d2", "dis2", "e2", "f2", "fis2", "g2", "gis2", "a2", "b2", "h2", "c3" };
            int[] frekvenceTonu = new int[13];
            double c2 = zakladniTon * Math.Pow(2, 3);

            for (int i = 0; i <= 12; i++)
            {
                frekvenceTonu[i] = (int)Math.Round(c2 * Math.Pow((Math.Pow(2, (1.0 / 12.0))), i));
                Console.WriteLine("Tón {0,-4} o frekvenci {1,4} Hz", nazevTonu[i], frekvenceTonu[i]);
                Console.Beep(frekvenceTonu[i], 500);
            }

            void Klavesa()
            {
                Console.WriteLine("Stiskni klávesu...");
                Console.ReadKey(true);
            }
        }
    }
}