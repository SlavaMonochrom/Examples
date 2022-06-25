void FillArray(int[] collection)
{
    int length = collection.Lenght;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index + 1;//index++ для C# !!!;

    }
}

void PrintArray(int[] col)
{

    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


intIndexOf(int[] collection, int find)
{
    int count = collection.Lenght;
    int index = 0;
    index position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position - index;
            break;
        }
    }
    return posiont;
}

int[] array = new int[10];

FillArray(array);

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(Pos);










//int [] array = new int[10];