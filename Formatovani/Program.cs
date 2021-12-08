double[] cislo = { 25.3, 189, 2.56698 };
for (int i = 0; i < 3; i++)
    Console.WriteLine($"číslo {i} = {cislo[i],8:N2}");

Console.WriteLine("Aktuální čas T je: {0:T}", DateTime.Now);
Console.WriteLine("Aktuální čas t je: {0:t}", DateTime.Now);
Console.WriteLine("Aktuální čas dddd je: {0:dddd}", DateTime.Now);
Console.WriteLine("Aktuální čas D je: {0:D}", DateTime.Now);
Console.WriteLine("Aktuální čas f je: {0:f}", DateTime.Now);
Console.WriteLine("Aktuální čas g je: {0:g}", DateTime.Now);
Console.WriteLine("Aktuální čas hh je: {0:hh}", DateTime.Now);
Console.WriteLine("Aktuální čas MMMM je: {0:MMMM}", DateTime.Now);