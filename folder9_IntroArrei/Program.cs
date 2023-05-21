// Задача с массивом

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} //           0    1    2   3   4   5    6   7     8
int[] array ={12, 5265, 54, 25, 52, 654, 54, 657, 8563 };

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);






















