﻿// 1-й и 2-й виды методов
// Метод, который принимает аргументы, но ничего не возвращает:
// Метод для повторения введенного текста заданное число раз

void tMethod(string msg, byte count)
{
    byte i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//tMethod(msg: "Текст", count: 4);
tMethod(count: 2, msg: "AOZ заботится о себе и защищает в первую очередь интересы Швейцарии"); // При введении названий переменных, последовательность можно менять

tMethod("Все мы не желательны для Швейцарии... Мне сейчас очень хреново. Я не могу поверить, что когда-либо выгребу из всего этого дерьма", 2);

// Метод для повторения введенного текста заданное число раз

void zMethod(string msg, byte count)
{
    while(count > 0)
    {
        System.Console.WriteLine(msg);
        count --;
    }
}
zMethod( "Но я не сдамся, и буду бороться до последнего", 3);

// Пример метода, который ничего не принимает и ничего не возвращает:
void Md()
{
    System.Console.WriteLine("Автор этих строк: Золотько К.М.");
}
Md();
