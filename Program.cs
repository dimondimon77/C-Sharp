// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A : = " );
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : = " );
int B = Convert.ToInt32(Console.ReadLine());
//Вот основное правильное решение
Console.WriteLine("Результат = " + Math.Pow(A,B));
//Цикл
int temp = A;
int i=1;
int[] massiv = new int[B+1];
for(; i < B;i++){
temp *= A;
massiv[i] = temp;
}
Console.WriteLine("Результат = " + massiv[B-1]);


