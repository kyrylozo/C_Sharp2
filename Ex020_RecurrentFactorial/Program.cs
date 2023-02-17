// Рекурсивное вычисление факториала

double Factorial (int n) // double используется, так как в результате появляются
//                          сллишком огромные числа для int
{
    // 1! = 1
    // 0! = 1
    if(n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(39));