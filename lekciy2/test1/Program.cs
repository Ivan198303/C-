// Нахождение максимального через функцию
int Max(int arg1, int arg2, int arg3)
{
    int resalt=arg1;
    if (arg2>resalt) resalt=arg2;
    if (arg3>resalt) resalt=arg3;
    return resalt;
}
int a1=15;
int b1=17;
int c1=22;
int a2=21;
int b2=28;
int c2=1258;
int a3=654;
int b3=89;
int c3=65;
//int max1=Max(a1, b1, c1);
//int max2=Max(a2, b2, c2);
//int max3=Max(a3, b3, c3);
//int max=Max(max1, max2, max3);
int max=Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3)); // убираем промежуточные переменные и используем вычисление максимального через применение функции в одну строку.
Console.WriteLine("Максимальное число = "+max);