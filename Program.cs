// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
    if(num>=100)
    {
    int reduction = num%100%10;
    Console.WriteLine(reduction);
    }
    else
    {
        Console.WriteLine("Вы ввели двухзначное число, и третей цифры нет");
    }
