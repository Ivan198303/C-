// двумерный массив для печати и рандомного заполнения
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //  Количество строк это относится к первой цифре new int[3, 4];
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Количество столбцов это относится ко второй цифре new int[3, 4];
    {
        {
            matr[i, j] = new Random().Next(1, 10);  //[1; 10) диапазон цифр для заполнения
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();  
PrintArray(matrix);