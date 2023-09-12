// Создание цикла в цикле (таблица умножения)

for ( int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");

    }
    Console.WriteLine();
}

for(byte ix = 9; ix > 1; ix--)
{
    for(byte jx = 9; jx > 1; jx--)
    {
        System.Console.WriteLine($"{ix} x {jx} = {ix * jx}");
    }
    System.Console.WriteLine();
}