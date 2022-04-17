double[] value = { 25.3, 189, 2.56698 };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"číslo {i} = {value[i],8:N2}");
}

Console.WriteLine();

Console.WriteLine("Aktuální čas T    : {0:T}", DateTime.Now);
Console.WriteLine("Aktuální čas t    : {0:t}", DateTime.Now);
Console.WriteLine("Aktuální čas dddd : {0:dddd}", DateTime.Now);
Console.WriteLine("Aktuální čas D    : {0:D}", DateTime.Now);
Console.WriteLine("Aktuální čas f    : {0:f}", DateTime.Now);
Console.WriteLine("Aktuální čas g    : {0:g}", DateTime.Now);
Console.WriteLine("Aktuální čas hh   : {0:hh}", DateTime.Now);
Console.WriteLine("Aktuální čas MMMM : {0:MMMM}", DateTime.Now);