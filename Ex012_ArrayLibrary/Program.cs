// # В начале создаються модули:
void FillArray(int[] collection) // "FillArray" - название метода для заполнения массива 
            // "void" - метод, кот. не возвращает каких-либо значений
            // "int[] collection" - Создание метода с аргументом: "collection"
{
    int length = collection.Length; // Определение длины массива length
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Генерация случайных чисел от 1 до 10
        // index = index + 1
        index++;
    }
}

void PrintArray(int[] col)  // Метод для печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count) // Имена аргументов отличаются от таковых в предыдущем методе, чтобы подчеркнуть, что они могут быт разными
    {
        Console.Write(col[position]);
        Console.Write(" | ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // Создание метода "IndexOf", возвращающего результат (содержит 2 аргумента)
{
    int count = collection.Length;
    int index = 0;
    //"int posit = 0;" - не оптимальное решение, так как при отсутствии искомого числа будет выдавать "0"
    int posit = -1; // - позволяет легко интерпретировать результат как ненайленный элемент

    while (index < count)
    {
        if(collection[index] == find)
        {
            posit = index;
            break;        // Цикл заканчивается после нахождения первого  == find
        }
        index++;
    }
    return posit;
}

// # Тут начинается программа:
int[] array = new int[12]; // Создание массива "array" и размещение в нем нужного количества элементов
                            // (по умолчанию - это нули)
FillArray(array);  // Запустить метод: "FillArraу"
array[2] = 4;      // Принудительное введение "4" на 2 позицию

PrintArray(array); // Запустить метод: "PrintArray"
Console.WriteLine();

int pos = IndexOf(array, 12); // В методе "IndexOf" - два аргумента: имя вводимого массива и число, которое необходимо найти
Console.Write("Индекс первого искомого числа в массиве: ");
Console.WriteLine(pos);