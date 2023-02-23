/*
**  *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *
Из имеющегося массива строк сформировать массив строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
// string[] array = {"hello", "2", "World", ":-)"};
/**/
Console.WriteLine(
    "Введите массив string элементов разделеных SPASE, SLASH, DOT или COMMA, в конце нажмите 'ENTER'"
);
string? str = Console.ReadLine();
string? strTmp = string.Empty;
int numbChar = 3;

char[] separator = new char[] { ' ', ',', '.', '/' };
string[] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);

/**/
Console.WriteLine();
Console.WriteLine($"Вывод Массива по выделению менее или равно {numbChar} символов:");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= numbChar)
    {
        strTmp = strTmp + array[i] + " ";
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Не очень понятно по заданию достаточно ли просто вывести массив до трех символов или обязательно "
                + "из него сформировать новый массив, поэтому далее идет формирование нового массива и его повторный вывод");
string[] arraySelect = strTmp.Split(separator, StringSplitOptions.RemoveEmptyEntries);

foreach (var item in arraySelect)
{
        Console.Write(item + " ");
}