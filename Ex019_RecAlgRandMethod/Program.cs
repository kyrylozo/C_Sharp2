// Создание таблицы и наполнение ее случайными числами

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}

int[,] matrix = new int[3, 10]; // new int [строки (matr.GetLength(0)), столбцы (matr.GetLength(1))]
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);