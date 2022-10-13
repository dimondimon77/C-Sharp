// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int[,] massiv = new int[4, 4];
int count = 1;
void FillRight(int[,] fill, int x, int y, int step)     //Метод который заполняет массив слева направо. Фиксируется строка, заполняются столбцы в положительную сторону.
                                                        //Принимает x и у и step. х - позиция строк, у - позиция столбцов,
                                                        //step - количество ячеек которые нужно заполнить
{
    x--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    y--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    for (int i = 0; i < step && y < fill.GetLength(1); y++, i++, count++) //Выполняется если step>0 и позиция столбца(y)<длины столбцов массива
    {
        fill[x, y] = count; //Заполняем здесь числом из счетчика count
    }
}
void FillLeft(int[,] fill, int x, int y, int step)      //Метод который заполняет массив справа налево. Фиксируется строка, заполняются столбцы в отрицательную сторону.
                                                        //Принимает x и у и step. х - позиция строк, у - позиция столбцов,
                                                        //step - количество ячеек которые нужно заполнит
{
    x--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    y--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    for (int i = 0; i < step && y < fill.GetLength(1); y--, i++, count++) //Выполняется если step больше 0 и позиция столбца(y) меньше длины столбцов массива
    {
        fill[x, y] = count; //Заполняем здесь числом из счетчика count
    }

}
void FillDown(int[,] fill, int x, int y, int step)      //Метод который заполняет массив сверху вниз. Фиксируется столбец, заполняются строки в положительную сторону.
                                                        //Принимает x и у и step. х - позиция строк, у - позиция столбцов,
                                                        //step - количество ячеек которые нужно заполнить
{
    x--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    y--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    for (int i = 0; i < step && x < fill.GetLength(0); x++, i++, count++) //Выполняется если step больше 0 и позиция строки(x) меньше длины строк массива
    {
        fill[x, y] = count; //Заполняем здесь числом из счетчика count
    }
}
void FillUp(int[,] fill, int x, int y, int step)        //Метод который заполняет массив снизу вверх. Фиксируется столбец, заполняются строки в отрицательную сторону.
                                                        //Принимает x и у и step. х - позиция строк, у - позиция столбцов,
                                                        //step - количество ячеек которые нужно заполнить
{
    x--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    y--;
    //Нужно чтобы мы смогли вводить координаты строк, столбцов, при вызове метода начиная с 1 а не с 0 и программа считала правильно при этом
    for (int i = 0; i < step && x < fill.GetLength(0); x--, i++, count++) //Выполняется если step больше 0 и позиция строки(x) меньше длины строк массива
    {
        fill[x, y] = count; //Заполняем здесь числом из счетчика count
    }
}
void PrintMassiv(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"{print[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
FillRight(massiv, 1, 1, 3);
FillDown(massiv, 1, 4, 3);
FillLeft(massiv, 4, 4, 4);
FillUp(massiv, 3, 1, 2);
FillRight(massiv, 2, 2, 2);
FillDown(massiv, 3, 3, 1);
FillLeft(massiv, 3, 2, 1);
PrintMassiv(massiv);

// Вариант решения через рекурсию
// Console.Clear();
// int[,] massiv = new int[,] {{1,1,1,1,1,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,1,1,1,1,1},};
// int x = 0;
// void Fill(int row, int col)
// {
//     x++;
//     if (x == 12)
//     {
//         Fill(row - 1, col);
//         massiv[2, 1] = 12;
//     }
//     if (massiv[row, col] == 0)
//     {
//         massiv[row, col] = x;
//         Fill(row, col + 1);
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row + 1, col);
//         }
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row, col - 1);
//         }
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row - 1, col);
//         }
//     }
// }

// void PrintMassiv(int[,] print)
// {
//     for (int i = 1; i < print.GetLength(0) - 1; i++)
//     {
//         for (int j = 1; j < print.GetLength(1) - 1; j++)
//         {
//             Console.Write($"{print[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Fill(1, 1);
// PrintMassiv(massiv);


