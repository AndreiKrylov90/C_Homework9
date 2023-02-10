// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
if (!int.TryParse(Console.ReadLine(), out int M) || M < 0)
{
    Console.WriteLine("Введено нецелое или отрицательное число");
    return;
}

Console.WriteLine("Введите число N");
if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
{
    Console.WriteLine("Введено нецелое или отрицательное число");
    return;
}

double Akkerman(double a, double b)
{
    if (a == 0) return b + 1;
    else
    {
        if (a != 0 && b == 0) return Akkerman(a - 1, 1);
        else
        {
            return Akkerman(a - 1, Akkerman(a, b - 1));
        }
    }

}

double result = Akkerman(M, N);
Console.WriteLine($"Функция Аккермана для чисел {M} и {N} принимает значение {result}");



