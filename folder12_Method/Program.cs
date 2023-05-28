// Методы Вид 1, Вид 2 ВОИТ Методы - которые ни чего не возвращают

// Вид 1 - ни чего не принимает, ни чего не возвращает

void Method1()
{
    Console.WriteLine("Автор....");
}
// Method1(); // скобки обязательны, без них не работает


// Вид 2 - что-то принимает, ни чего не возврашает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый текст");


//   Вид 3 - ни чего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


// Вид 4 - что-то принимают, что-то возвращают

// Испоьзуем цикл while

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "урок");
// Console.WriteLine(res);

// Используем цикл for

string Method4(int count, string text)
{    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "урок");
// Console.WriteLine(res);



// Испльзуем цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j =2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i *j}");
//     }
//     Console.WriteLine();
// }


// Работа с текстом

// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", большие "С" заменить
// маленькими "с".


string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали в место нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?0";


// string s = "qwerty"
//             012345
// s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }   
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// // Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


int[] arr = {1, 5, 8, 6, 9, 3, 4, 6, 3, 4, 8};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [ i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i =0; i < array.Length -1; i++)
    {
        int minPosition =i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);