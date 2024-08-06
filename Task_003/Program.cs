// Задача №3
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию. Не использовать циклы

void Main()
{
    int [] array = {1, 2, 3, 4, 5};
    PrintArray(array);
}

void PrintArray (int [] arr)
{
    if (arr.Length < 1) return;
    System.Console.Write(arr[arr.Length - 1] + " ");
    arr = arr[0..(arr.Length-1)];
    PrintArray(arr);
}

Main();
