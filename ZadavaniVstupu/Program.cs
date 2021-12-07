namespace ZadavaniVstupu
{
    public class Program
    {
        public static void Main()
        {
            ConsoleKey znak = Console.ReadKey(true).Key;
            Console.WriteLine($"Stiskl jsi klavesu {znak}");
        }
    }
}