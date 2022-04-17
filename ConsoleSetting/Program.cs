Console.SetWindowSize(1, 1);
Console.SetBufferSize(110, 40);
Console.SetWindowSize(50, 20);

for (int i = 0; i < 40; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(j + " ");
    }

    Console.Write("\n");
}

Console.WindowLeft = 10;
Console.WindowTop = 7;
Console.ReadKey();
