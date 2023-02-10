// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
if (!int.TryParse(Console.ReadLine(), out int M) || M < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}

Console.WriteLine("Введите число N");
if (!int.TryParse(Console.ReadLine(), out int N) || N < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}

int SumsFromMtoN(int a, int b)
{
    if (a <= b)
    {
        if (b == a) return a;
        else return b + SumsFromMtoN(a, b - 1);
    }
    else
    {
        if (a == b) return b;
        else return a + SumsFromMtoN(a - 1, b);
    }
}

Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumsFromMtoN(M, N)}");

