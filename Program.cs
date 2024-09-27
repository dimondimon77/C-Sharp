// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
int num = new Random().Next(1, 100000000);
int temp = 0;
int ten = 10;
int ten2 = 10;
int count = 0;
int countTarget = 3;
int number = 0;
temp = num;
if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else{
while(temp>10){
    temp = num/ten;
    ten *= 10;
}
while(count<countTarget)
{
    count++;
    temp *= ten;
    ten /= 10;
    temp = num/ten;
    number = temp;
    number %= ten2;
    Console.WriteLine($"{count}" + "-ая цифра = " + $"{number}");
}
if (count==countTarget)
{
    Console.WriteLine(num);
    Console.WriteLine("Искомая цифра := " + number);
}
}
