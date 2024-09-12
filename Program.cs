// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();
double[,] massiv = new double[3, 4];
void RandomMassiv(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10,10) + new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j],1);
        }
    }
}
void PrintMassiv(double[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"[{print[i, j]}] ");
        }
        Console.WriteLine();
    }
}
RandomMassiv(massiv);
PrintMassiv(massiv);

