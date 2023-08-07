int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
// Индексы array: 0, 1,  2, .....................8
int [] array = { 11, 21, 311, 41, 15, 61, 17, 18, 19 };
array[3] = 5555;
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
  
Console.WriteLine(result);


int [] ar = { 11, 21, 311, 41, 15, 61, 1777, 18, 19 };
ar[7] = 4000;

int result1 = Max(
    Max(ar[0], ar[1], ar[2]),
    Max(ar[3], ar[4], ar[5]),
    Max(ar[6], ar[7], ar[8])
);
Console.WriteLine(result1);
Console.WriteLine(array[5]);
