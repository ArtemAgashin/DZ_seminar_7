// Задача №2
// Напишите программу вычисления функции Аккермана
// с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void Main()
{
    int number_m = ReadInt_m("Введите значение m: ");
    int number_n = ReadInt_n("Введите значение n: ");
    int number = A(number_m, number_n);
    System.Console.WriteLine(number);
}

int ReadInt_m (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadInt_n (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)
{
    if (m == 0)
        return n+1;
    else if (m> 0 && n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m,n - 1));
}
Main();