// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число : = " );
String? num = Convert.ToString(Console.ReadLine()); // String? - знак "?" означает что данный тип String допускает значение null или 0
int sum = num.Where(Char.IsDigit).Sum(c => c - '0'); //Сканирует каждый символ в строке на наличие цифр от 0 до 9 и затем складывает все найденные цифры между собой, Возвращяет Integer
Console.WriteLine(sum);

// Решение через Математические операции (Only Integer)
// Console.WriteLine("Введите число : = " );
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = 0;
// int ten = 10;
// int count = 0;
// int i = -1;
// int number = 0;
// int result = 0;
// temp = num;
// while(temp>10){
//     temp = num/ten;
//     ten *= 10;
//     count++;
// }
// while(i<count)
// {
//     i++;
//     temp *= ten;
//     ten /= 10;
//     temp = num/ten;
//     number = temp;
//     number %= 10;
//     result += number;
// }
// Console.WriteLine(result);

