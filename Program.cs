// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число N : = " );
int N = Convert.ToInt32(Console.ReadLine());
// int num = new Random().Next(1,99999);
int[] massiv = new int[N];
int i = 1;
for(;i < massiv.Length;i++)
{
    int degree = Convert.ToInt32(Math.Pow(i, 3));
    massiv[i] = degree;
    Console.WriteLine(massiv[i]);
}