// Вычисление факториала
double Factorial(int n) // так как если при использовании int Factorial(int n) мы получаем переполнение используется тип данных double
{
    // 1! = 1 
    // 0! = 1 
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// вычисление числа фибоначи
// f(1) = 1 
// f(2) = 1 
// f(n) = f(n-1) + f(n-2)
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    for (int i = 1; i < 50; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    }