// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число число : = " );
int num = Convert.ToInt32(Console.ReadLine());
Boolean saturday = true;
Boolean sunday = true;
saturday = num == 6;
sunday = num == 7;
    if(num>7)
    {
    Console.WriteLine("Вы ввели число которое превышает количество дней в неделе, пожалуйста повторите попытку");
    return;
    }
    if(saturday|sunday)
    {
        Console.WriteLine("Да");
    }
    if(!(saturday|sunday))
    {
        Console.WriteLine("Нет");
    }
