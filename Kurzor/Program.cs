int xStartVypisu = 5;
int yStartVypisu = 2;
Console.SetCursorPosition(xStartVypisu, yStartVypisu);

Console.Write($"█ xStartVypisu = {xStartVypisu}, yStartVypisu = {yStartVypisu}");

int xPrirustek = 7;
int yPrirustek = -2;
Console.SetCursorPosition(xStartVypisu + xPrirustek, yStartVypisu + yPrirustek);

int xCilVypisu = Console.CursorLeft;
int yCilVypisu = Console.CursorTop;
Console.Write($"█ xCilVypisu = {xCilVypisu}, yCilVypisu = {yCilVypisu}");

Console.SetCursorPosition(0, yStartVypisu + 1);

for (int i = 1; i <= 10; i++)
{
    Console.CursorSize = i * 10;
    Console.Write("\nVelikost kurzoru ={0,5}%, stiskni klávesu...", Console.CursorSize);
    Console.ReadKey(true);
}
