ConsoleKeyInfo zadani;

start:

Console.WriteLine("Stiskni klávesu");
zadani = Console.ReadKey(true);

Console.WriteLine("Znak : " + zadani.KeyChar);
Console.WriteLine("Klávesa : " + zadani.Key);
Console.WriteLine("Modifikátory : " + (zadani.Modifiers == 0 ? "-" : zadani.Modifiers));

goto start;