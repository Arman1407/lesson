// Заполняет массив случайными цифрами в указанном диапозоне (1-10)
// void - метод который не возврашает

void FillArray(int[] collection)
{
    int length = collection.Length; // длина массива
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(1, 10); // новое случайное число из диапозона от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // создай новый массив с 10 элементам

FillArray(array);   // наименование массива
array[4] = 4;
array[6] = 4;

PrintArray(array);  // распечатывает массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

