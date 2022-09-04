// Нахождение элемента массива равный запрашиваемому
int [] array={11,24,36,44,52,44,17,93};
int n=array.Length; // колличество элементов в массиве, длинна массива
int find=22;
int index=0;
try
    {
    while(index<n)
        {
            if (array[index]==find)
            {
                Console.WriteLine("найденное число "+index);
                break;
            }
            index++;
        }
    }
catch 
{
Console.WriteLine("Нет запрашиваемого числа ");
}