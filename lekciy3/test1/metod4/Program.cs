//Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
//возвращает для дальнейшей работы.
// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;// String.Empty это означает что изначально он будет пустой строкой
//     while (i<count)
//     {
//     result = result + text;
//     i++;
//     }
//     return result;
// }
// string res = Metod4(4, "asdf");
// Console.WriteLine(res);

// Использование цикла for
string Metod4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i<count; i++)
{
result = result + text;
}
return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);