﻿// ====== Работа над текстом =======
// В тексте все пробелы заменить черточками, маленькие буквы _к_ 
// заменить большими _К_, а большие _С_ заменить маленькими _с_

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "querty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ','|'); 
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к','К'); 
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'В','в'); 
Console.WriteLine(newText);
Console.WriteLine();


string Replace2 (string text, char oldValue, char newValue)
{
    string result2 = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue)
        {
            result2 = result2 + newValue;
        }
        else result2 = result2 + text[i];
    }
    return result2;
}

// System.Console.WriteLine($"{Replace2(text, " ", "-")}");
// System.Console.WriteLine();

string nwText = Replace2(text, 'л', 'Л'); 
Console.WriteLine(nwText);
Console.WriteLine();