// 1. Получение данных без введения в терминал
// 2. Введение текста заданное количество раз

//int Time()
//{
    //return DateTime.Now.Year;
//}
//Console.WriteLine(Time());


string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Text ");
Console.WriteLine(res);
