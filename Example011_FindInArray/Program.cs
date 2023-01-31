
// ar = array
int [] ar = { 11, 21, 31, 16, 51, 16, 71, 18, 19 };
 
int n = ar.Length;
int find = 13;
            // 1. Установить счетчик index в позицию 0
int index = 0;
            // 2. Усли array [index] = find, алгоритм завершил работу успешно
while(index < n)
{
    if(ar[index] == find)
    {
        Console.WriteLine(index);
        break; // заканчивает цикл (будет отискиваться только 1-й элемент)
    }
            // 3. Увеличить индекс на 1
         //  index = index + 1;
    index++; // 4. Если index < n то перейти к шагу 2. В противном случае алгоритм завершил работу бузуспешно.
}