// Задача 1
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int number_M = ReadInt_M("Введите число M: ");
    int number_N = ReadInt_N("Введите число N: ");
    PrintNumber (number_M, number_N);
}

int ReadInt_M (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadInt_N (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber (int M, int N)
{
    if (N < M) return;
        System.Console.Write(M + " ");
        PrintNumber (M+1, N);
}

Main();