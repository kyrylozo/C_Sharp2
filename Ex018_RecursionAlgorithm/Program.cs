// Создание пустого двумерного массива


// string[,] table = new string[2, 5];
// //        Для строк инициализация производится: "String.Empty"
// //       table[0,0]  table[0,1].  table[0,2] ... table[0,4]
// //       table[1,0]  table[1,1].  table[1,2] ... table[1,4]
// table[1, 2] = "word";
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//     Console.WriteLine($"- {table[rows, columns]}-");
//     }
// }
// Строки с 17 по 25 должны быть активны
// int[,] matrix = new int[3, 6];
//for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}");
    }
    System.Console.WriteLine();
}

