using System;

namespace JednaciMistnost
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("######  JEDNACÍ MÍSTNOST  ######");
            Console.WriteLine("Při příchodu účastníka stiskni šipku nahoru, po odchodu stiskni šipku dolů.");
            Console.WriteLine("Pro ukončení programu stiskni ESC.");
            Console.WriteLine();

            var jednaciMistnost = new JednaciMistnost(0);
            Console.WriteLine(jednaciMistnost);

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    jednaciMistnost.PocetLidi++;
                    Console.WriteLine(jednaciMistnost);
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    jednaciMistnost.PocetLidi--;
                    Console.WriteLine(jednaciMistnost);
                }
            } 
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}