// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Find1(int num)
{
    if (num == 1) return num;
    else { Console.Write($"{num} "); return Find1(num - 1); }
}
Console.WriteLine(Find1(8));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Find2(int M, int N)
{
    if (M==N) return M;
    else return M + Find2(M + 1, N);
}
Console.WriteLine(Find2(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m == 1) return n + 2;
    if (m == 2) return 2 * n + 3;
    else return Convert.ToInt32(Math.Pow(2, (n + 3)) - 3);
}
Console.WriteLine(Akkerman(2, 4));
