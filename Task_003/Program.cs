// Задача №3
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию. Не использовать циклы

void Main()
{
    int [] array = new int [10];
    Random rand = new Random();
    System.Console.WriteLine("Исходный произвольный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(0,100);
        Console.Write (array[i] + "\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Перевернутый массив: ");
    PrintArray(array);
}

void PrintArray (int [] arr)
{
    if (arr.Length < 1) return;
    System.Console.Write(arr[arr.Length - 1] + "\t");
    arr = arr[..(arr.Length-1)];
    PrintArray(arr);
}


Main();
