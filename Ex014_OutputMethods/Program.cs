 // 3. Методы, которые ничего не принимают, но что-то возвращают
 // Получение данных без введения в терминал

int Time()
{
    return DateTime.Now.Year;
}
int year = Time();
Console.WriteLine(Time() - 2);
Console.WriteLine(year + 1);

// 4. Методы, которые что-то прирнимает и что-то возвращает
 // Введение текста заданное количество раз

string Method4(byte count, string text)
{
    string result = String.Empty;
    for(byte i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(3, "Y");
Console.WriteLine(res);

string Method5(byte count, string text)
{
    string result = String.Empty;
    for(; count > 0; count--)
    {
        result = result + text;
    }
    return result;
}
string reslt = Method5(3, "Z");
Console.WriteLine(reslt);