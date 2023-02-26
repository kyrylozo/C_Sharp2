// Сумма числел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for(int i = 1; i <= n; i++) result +=i;
    return result;
}

int SumRec(int n)
{
    if(n == 0) return 0; // (обязательные условия выхода)
    else return n + SumRec(n - 1);
}
System.Console.WriteLine(SumFor(10));
System.Console.WriteLine($"Sum of numbers Recursion: {SumRec(10)}");
// _________________________________________________
// ФАКТОРИАЛ ЧИСЛА N

int FactorialFor(int n)
{
    int count = 1;
    for(byte i = 1; i <= n; i++)
    {
        count *= i;
    }
    return count;
}
System.Console.WriteLine($"Факториал числа = {FactorialFor(5)}");

int FactorialRec(int n)
{
    if(n == 1 || n == 0) return 1;
    // else n *= FactorialRec(n - 1);
    // return n;
    else return n * FactorialRec(n - 1);
}
System.Console.WriteLine($"Number factorial Recursion = {FactorialRec(5)}");
System.Console.WriteLine("_____________________________________________");
int PowerFor(int a, int n)
{
    int result = 1;
    for(int ix = 1; ix <= n; ix++)
    {
        result *= a;
    }
    return result;
}
System.Console.WriteLine($"Степень N числа А = {PowerFor(2, 10)}");

int PowerRec(int a, int n)
{
    // if(n == 0) return 1;
    // else return PowerRec(a, n - 1) * a;
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}
System.Console.WriteLine(PowerRec(2, 10));