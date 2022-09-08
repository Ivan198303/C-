// Использование метод4 и цикла for
// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";
string Replase(string text, char oldValue, char newValue)
{
string result = String.Empty;      // Начало пустой результат
int length = text.Length;          // Чтобы получить длинну в строке, через обращение к свойству строки, показывающие кол-во символов в строке  
for (int i = 0; i < length; i++)
{
if(text[i] == oldValue) result = result + $"{newValue}";
else result = result + $"{text[i]}";
}
return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replase(newText, 'к', 'К'); // Чтобы продолжить изменения указать уже измененый текст.
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replase(newText1, 'с', 'С'); 
Console.WriteLine(newText2);