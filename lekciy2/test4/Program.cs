// рандомное заполнение количества массива и элементов массива. Нахождение индекса запрашиваемого элемента в массиве.
void FillArray(int[] collection) // void метод котрый ни чего не возвращает
{
    int length = collection.Length; // данный войд делает случайный набор в массиве 
    int index=0;
    while (index < length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
int [] array=new int[10];
void PrintArray(int[] col) // метод печатает массив
{
    int count = col.Length;
    int posityion =0;
    while (posityion<count)
    {
    Console.WriteLine(col[posityion]);
    posityion++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=-1; // если элемента нет будет писать -1
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int []Array= new int[10]; // задаем массив с 10 элементами, индекс от 0 до 9.

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos=IndexOf(array,21);
Console.WriteLine(pos);