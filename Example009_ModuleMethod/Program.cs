
// ---------------------------------------------------------
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15,
    b1 = 21,
    c1 = 3349,
    a2 = 12,
    b2 = 23,
    c2 = 33,
    a3 = 3,
    b3 = 213,
    c3 = 1033;

    int maxx1 = Max(a1, b1, c1);
    int maxx2 = Max(a2, b2, c2);
    int maxx3 = Max(a3, b3, c3);
    int maxx = Max(maxx1, maxx2, maxx3);
// Можно использовать вышеприведенный код, но проще - тот, что в 25 - 28 строке
    int max = Max(
        Max(a1, b1, c1),
        Max(a2, b2, c2),
        Max(a3, b3, c3));
    
    
  Console.WriteLine(maxx);
  Console.WriteLine(max);