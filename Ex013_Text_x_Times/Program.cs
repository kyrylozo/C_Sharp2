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
tMethod(count: 4, msg: "Текст"); // При введении названий переменных, последовательность можно менять

// tMethod("Hellow everybody", 4);


