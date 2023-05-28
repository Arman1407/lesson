// Задача с массивом

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} //           0    1    2   3   4   5    6   7     8
int[] array ={12, 5265, 54, 25, 52, 654, 54, 657, 8563 };
// array[0] = 6;               // обращается к массиву и записывает в него значение
// Console.WriteLine(array[1]); // обращается к массиву и получить из него значение по указанному индексу


int result = Max
(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);



















