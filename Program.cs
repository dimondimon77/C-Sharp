// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
Console.WriteLine("Введите число num3 : = " );
Console.WriteLine("Введите число num4 : = " );
Console.WriteLine("Введите число num5 : = " );
Console.WriteLine("Введите число num6 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
int num4 = Convert.ToInt16(Console.ReadLine());
int num5 = Convert.ToInt16(Console.ReadLine());
int num6 = Convert.ToInt16(Console.ReadLine());
if(num1>num2)
Console.WriteLine("Максимальное число: =" + num1);
else
Console.WriteLine("Максимальное число: =" + num2);
if(num3>num4)
Console.WriteLine("Максимальное число: =" + num3);
else
Console.WriteLine("Максимальное число: =" + num4);
if(num5>num6)
Console.WriteLine("Максимальное число: =" + num5);
else
Console.WriteLine("Максимальное число: =" + num6);

