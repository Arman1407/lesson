// Подход 1 - 
// Подход 2 - реурсивный подход

/*//Задача 1

//Собрать строку с числами от а до b, а <= b

// Подход 1
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

// Подход 2
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

 Console.WriteLine(NumbersRec(1, 10));
*/

/*//Задача 2

//Собрать строку с числами от а до b, а >= b

// Подход 1
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));


// Подход 2
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
 
Console.WriteLine(NumbersRec(1, 10));
*/

/*// Задача 3

// Сумма чисел от 1 до n

// Подход 1
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i ++) result += i;
    return result;
}

Console.WriteLine(SumFor(10)); // 55


// Подход 2
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumRec(10)); // 55
*/

/*// Задача 4

// Факториал числами

// Подход 1
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

Console.WriteLine(FactorialFor(10));  //  3628800

// Подход 2
int FactorialRec(int n)
{
   if (n == 1) return 1;
   else return n * FactorialRec(n -1);
}

Console.WriteLine(FactorialRec(10)); // 3628800
*/

/*// Задача 5

// Вычислить a в степени n

// Подход 1
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

Console.WriteLine(PowerFor(2, 10)); // 1024

// Подход 2
int powerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a. n - 1) * a;
    if (n == 0) return 1;
    else return powerRec(a, n - 1) * a;
}

Console.WriteLine(powerRec(2, 10)); // 1024

// Подход 3
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10)); // 1024
*/

/*// Задача 6

// Определение вариантов комбинаций от степени

int n = 1;
void FindWords(string alphabet,    char[] word,    int length = 0)
//             метод          | массив из букв    | собирает длину
//             передается     | который будет     | слова
//             строкой        | сост-ть нов слово |

{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for(int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);
*/

/*// Задача 7

// Показывает количество и наименование документов в указанной директории

void CatalogInfo(string path,   string indent = "")
//               путь к теущей| делает отступы, что позволяет
//               папке        | видеть структуру папки

{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем инфу о папке в которую зашли

    DirectoryInfo[] catalogs = catalog.GetDirectories();//получаем массив всех файлоа находящичся в этой папке
    for (int i = 0; i < catalogs.Length; i++)           // пробегаем/просматриваем по ним
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent +" ");
    }

    FileInfo[] files = catalog.GetFiles(); // выводит весь список файлов текущей директории

    for (int i = 0; i < files.Length; i++)  // показывает этот список
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = C:\Users\Admin\Desktop\Локальный диск (D)\ГикБреинс\Языки программирования\C#\lesson\folder1_HelloConsole;
CatalogInfo(path);
*/


/*// Задача 8

// Перекладывание блинов в пирамиде

void Towers(string with = "1", string on = '3', string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count -1);
}

Towers();
*/

