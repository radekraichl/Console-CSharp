Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();

Console.WriteLine("Následující věta bude tmavě zelená na žlutém pozadí.");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("Tato věta je opravdu tmavě zelená na žlutém pozadí.");
Console.WriteLine();

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

for (int colorNumber = 0; colorNumber < colors.Length; colorNumber++)
{
    Console.BackgroundColor = colorNumber == 0 ? ConsoleColor.Gray : ConsoleColor.Black;

    Console.ForegroundColor = colors[colorNumber];
    Console.WriteLine($"Barva číslo {colorNumber} je {colors[colorNumber]}");
}

Console.WriteLine();

ConsoleColor[] colorsArray = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Yellow };

foreach (var color in colorsArray)
{
    Console.ForegroundColor = color;
    Console.WriteLine($"Toto je barva {color} ({color:D})");
}

Console.ResetColor();
