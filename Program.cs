//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int reduction = num%100;
reduction = reduction%10;
Console.WriteLine(reduction);