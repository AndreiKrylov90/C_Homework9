// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число n");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}

void PrintNaturalsFromNto0(int n)
{
    if (n == 1) Console.Write($"{n} ");
    else
    {
        Console.Write($"{n} ");
        PrintNaturalsFromNto0(n - 1);
    }
}

PrintNaturalsFromNto0(n);
