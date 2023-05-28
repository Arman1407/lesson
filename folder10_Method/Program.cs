// Определение номера элемента по цифре в массиве

int[] array = {12, 26, 65, 45, 54, 68, 45, 65, 85};

int n = array.Length; //возвращает количество эллементов массива
int find = 45;   // цифра в массиве

int index = 0;  // начинаем с 1-го элемента

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
index++;
}