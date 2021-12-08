using System;

namespace ZadavaniVstupu
{
    public class Program
    {
        public enum Tones
        {
            c2 = 523,
            cis2 = 554,
            d2 = 587,
            dis2 = 622,
            e2 = 659,
            f2 = 698,
            fis2 = 740,
            g2 = 784,
            gis2 = 831,
            a2 = 880,
            b2 = 932,
            h2 = 988,
            c3 = 1046
        }

        public static void Main()
        {
            Console.WriteLine("Přehrávání náhodné melodie");
            Console.WriteLine("Pro start stiskni libovolnou klávesu.");
            Console.WriteLine("Pro ukončení stiskni Escape...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            Random random = new Random();

            while (keyInfo.Key != ConsoleKey.Escape)
            {
                Array values = Enum.GetValues(typeof(Tones));
                Tones randomTone = (Tones)values.GetValue(random.Next(values.Length));

                //Generování náhodné doby trvání tónu - celá, půlová, čtvrťová, osminová
                int duration = (int)Math.Round(600 / Math.Pow(2, random.Next(0, 4)));

                Console.WriteLine($"{randomTone} {duration} ms");
                Console.Beep((int)randomTone, duration);

                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }
        }
    }
}