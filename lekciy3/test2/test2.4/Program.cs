// 1. Перевернуть массив.
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
    Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
            minPosition = j;
        
        int temporary = array[i]; // временная переменная
        array[i] = array[minPosition]; // обмен переменными начальной 
        array[minPosition] = temporary; // возврат временной переменной вместо взятой
        }  
    }
}
PtintArray(arr);
selectionSort(arr);
PtintArray(arr);
