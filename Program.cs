// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
// int num = new Random().Next(12320,12324);
int[] massiv = new int[5];
for(int i = 0, ten = 1; i < massiv.Length;i++)
{
    ten *= 10;
    massiv[i] = (num%ten)/(ten/10);
}
if(massiv[0] == massiv[4] & massiv[1] == massiv[3])
    {
    Console.WriteLine("Число явялется палиндромом");
    }
else
    {
    Console.WriteLine("Число не явялется палиндромом");  
    }
