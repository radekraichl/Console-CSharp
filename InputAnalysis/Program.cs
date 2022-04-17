ConsoleKeyInfo input;

do
{
    Console.WriteLine("Stiskni klávesu");
    input = Console.ReadKey(true);

    Console.WriteLine($"Znak : {input.KeyChar}");
    Console.WriteLine($"Klávesa : {input.Key}");
    Console.WriteLine($"Modifikátory :  {(input.Modifiers == 0 ? "-" : input.Modifiers)}");
    Console.WriteLine();
}
while (input.Key != ConsoleKey.Escape);